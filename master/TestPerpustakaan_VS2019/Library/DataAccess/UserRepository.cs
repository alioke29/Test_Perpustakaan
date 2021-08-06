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
    public class UserRepository 
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;

        public UserRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }


        public List<UserEntity.User> GetList()
        {

            List<UserEntity.User> result = null;

            try
            {
                result = (from row in context.Users
                          select new UserEntity.User
                          {
                              ID = row.ID,
                              IDRole = row.IDRole,
                              IDLocation = row.IDLocation,
                              Code = row.Code,
                              UserName = row.UserName,
                              Fullname = row.Fullname,
                              Email = row.Email,
                              Password = row.Password,
                              IsLogin = row.IsLogin,
                              IsActive = row.IsActive,
                              LastLoginDate = row.LastLoginDate,
                              CreatedDate = row.CreatedDate,
                              CreatedBy = row.CreatedBy,
                              UpdatedDate = row.UpdatedDate,
                              UpdatedBy = row.UpdatedBy
                          }).ToList();
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public List<UserEntity.User> GetListById(int id)
        {

            List<UserEntity.User> result = null;

            try
            {
                result = (from row in context.Users
                          where row.ID == id
                          select new UserEntity.User
                          {
                              ID = row.ID,
                              IDRole = row.IDRole,
                              IDLocation = row.IDLocation,
                              Code = row.Code,
                              UserName = row.UserName,
                              Fullname = row.Fullname,
                              Email = row.Email,
                              Password = row.Password,
                              IsLogin = row.IsLogin,
                              IsActive = row.IsActive,
                              LastLoginDate = row.LastLoginDate,
                              CreatedDate = row.CreatedDate,
                              CreatedBy = row.CreatedBy,
                              UpdatedDate = row.UpdatedDate,
                              UpdatedBy = row.UpdatedBy
                          }).ToList();
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public List<UserEntity.User> GetListByFilter(string fullname, string email, string isActive, string roleId)
        {
            List<UserEntity.User> result = null;

            try
            {
                result = (from row in context.Users
                          select new UserEntity.User
                          {
                              ID = row.ID,
                              IDRole = row.IDRole,
                              IDLocation = row.IDLocation,
                              Code = row.Code,
                              UserName = row.UserName,
                              Fullname = row.Fullname,
                              Email = row.Email,
                              Password = row.Password,
                              IsLogin = row.IsLogin,
                              IsActive = row.IsActive,
                              LastLoginDate = row.LastLoginDate,
                              CreatedDate = row.CreatedDate,
                              CreatedBy = row.CreatedBy,
                              UpdatedDate = row.UpdatedDate,
                              UpdatedBy = row.UpdatedBy
                          }).ToList();

                if (!string.IsNullOrEmpty(fullname))
                    result = result.Where(x => x.Fullname.ToLower().Contains(fullname.ToLower())).ToList();

                if (!string.IsNullOrEmpty(email))
                    result = result.Where(x => x.Email.ToLower().Contains(email.ToLower())).ToList();

                if (!string.IsNullOrEmpty(isActive))
                    result = result.Where(x => x.IsActive == Convert.ToBoolean(isActive)).ToList();

                if (!string.IsNullOrEmpty(roleId))
                    result = result.Where(x => x.IDRole == Convert.ToInt16(roleId)).ToList();

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public object Add(UserEntity.User user)
        {

            object result = null;

            try
            {
                result = context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Update(UserEntity.User user)
        {

            object result = null;

            try
            {

                var userEntity = context.Users.FirstOrDefault(x => x.ID == user.ID);               

                userEntity.Fullname = user.Fullname;
                userEntity.Code = user.Code;
                userEntity.UserName = user.UserName;
                userEntity.Password = user.Password;
                userEntity.Fullname = user.Fullname;
                userEntity.Email = user.Email;
                userEntity.IDLocation = user.IDLocation;
                userEntity.IDRole = user.IDRole;
                userEntity.IsLogin = user.IsLogin;
                userEntity.IsActive = user.IsActive;
                userEntity.CreatedDate = user.CreatedDate;
                userEntity.CreatedBy = user.CreatedBy;
                userEntity.UpdatedDate = user.UpdatedDate;
                userEntity.UpdatedBy = user.UpdatedBy;
                context.Users.UpdateRange(userEntity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object UpdateChangePassword(UserEntity.User user)
        {

            object result = null;

            try
            {

                var userEntity = context.Users.FirstOrDefault(x => x.ID == user.ID);

                userEntity.Password = user.Password;
                userEntity.UpdatedDate = user.UpdatedDate;
                userEntity.UpdatedBy = user.UpdatedBy;
                context.Users.UpdateRange(userEntity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object UpdateIsLogin(UserEntity.User user)
        {

            object result = null;

            try
            {

                var userEntity = context.Users.FirstOrDefault(x => x.ID == user.ID);

                userEntity.IsLogin = user.IsLogin;
                userEntity.LastLoginDate = user.LastLoginDate;

                context.Users.UpdateRange(userEntity);
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

            UserEntity.User user = new UserEntity.User();
            object result = null;

            try
            {
                user.ID = id;
                result = context.Users.Remove(user);
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
