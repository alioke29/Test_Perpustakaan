using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using TestPerpustakaan_VS2019.Models;

using TestPerpustakaan_VS2019.Library;
using TestPerpustakaan_VS2019.Library.Entities;
using TestPerpustakaan_VS2019.Library.Utilities;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace TestPerpustakaan_VS2019.Library.DataAccess
{
    public class RoleRepository
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;

        public RoleRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                                   SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        public IEnumerable<RoleEntity.Role> GetList()
        {

            IEnumerable<RoleEntity.Role> result = null;

            try
            {
                result = (from row in context.Roles
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }

        public IEnumerable<RoleEntity.Role> GetListById(long id)
        {

            IEnumerable<RoleEntity.Role> result = null;

            try
            {
                result = (from row in context.Roles
                          where row.ID == id
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }

        public IEnumerable<RoleEntity.Role> GetListByFilter(string roleName)
        {
            IEnumerable<RoleEntity.Role> result = null;

            try
            {
                result = (from row in context.Roles
                          select row);

                if (!string.IsNullOrEmpty(roleName))
                    result = result.Where(x => x.RoleName.ToLower().Contains(roleName.ToLower()));
                
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }
        public object Add(RoleEntity.Role role)
        {

            object result = null;

            try
            {
                result = context.Roles.Add(role);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Update(RoleEntity.Role role)
        {

            object result = null;


            try
            {

                var roleEntity = context.Roles.FirstOrDefault(item => item.ID == role.ID);

                roleEntity.RoleName = role.RoleName;
                roleEntity.Desc = role.Desc;
                roleEntity.CreatedDate = role.CreatedDate;
                roleEntity.CreatedBy = role.CreatedBy;
                roleEntity.UpdatedDate = role.UpdatedDate;
                roleEntity.UpdatedBy = role.UpdatedBy;
                context.Roles.UpdateRange(roleEntity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Delete(int id)
        {

            RoleEntity.Role role = new RoleEntity.Role();
            object result = null;

            try
            {
                role.ID = id;
                result = context.Roles.Remove(role);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }





    }
}
