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
    public class MenuRepository
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;
        public MenuRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        public List<MenuEntity.Menu> GetList()
        {

            List<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          }).ToList();

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public List<MenuEntity.Menu> GetParentList()
        {

            List<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          where !string.IsNullOrEmpty(row.ParentMenuCode)
                          select new MenuEntity.Menu
                          {
                              ParentMenuCode = row.Code,
                              DisplayName = row.DisplayName
                          }).Distinct().ToList();

                result = result.Where(x => !string.IsNullOrEmpty(x.ParentMenuCode)).ToList();

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public IEnumerable<MenuEntity.Menu> GetListById(int id)
        {

            IEnumerable<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          where row.ID == id
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          });
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public IEnumerable<MenuEntity.Menu> GetListByCode(string code)
        {

            IEnumerable<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          where row.Code == code
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          });
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public IEnumerable<MenuEntity.Menu> GetListMenuByRole(int roleId)
        {
            IEnumerable<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          join b in context.UserRoles on row.Code equals b.MenuCode
                          where b.IsActiveMenu == true &&
                                b.IDRole == roleId
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          });
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }

        public IEnumerable<MenuEntity.Menu> GetListMenuByParentAndMenuCode(string menuCode, string subMenuCode)
        {
            IEnumerable<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          where row.ParentMenuCode == menuCode &&
                                row.Code == subMenuCode
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          });
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }
        public List<MenuEntity.Menu> GetListByFilter(string menuName, string parentMenuCode)
        {
            List<MenuEntity.Menu> result = null;

            try
            {
                result = (from row in context.Menus
                          select new MenuEntity.Menu
                          {
                              ID = row.ID,
                              Code = row.Code,
                              DisplayName = row.DisplayName,
                              UrlNav = row.UrlNav,
                              ParentMenuCode = row.ParentMenuCode,
                              SortNumber = row.SortNumber
                          }).ToList();

                if (!string.IsNullOrEmpty(menuName))
                    result = result.Where(x => x.DisplayName.ToLower().Contains(menuName.ToLower())).ToList();

                if (!string.IsNullOrEmpty(parentMenuCode))
                    result = result.Where(x => x.ParentMenuCode == parentMenuCode).ToList();

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public object Add(MenuEntity.Menu menu)
        {

            object result = null;

            try
            {
                result = context.Menus.Add(menu);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Update(MenuEntity.Menu menu)
        {

            object result = null;

            try
            {
                result = context.Menus.Update(menu);
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

            MenuEntity.Menu menu = new MenuEntity.Menu();
            object result = null;

            try
            {
                menu.ID = id;
                result = context.Menus.Remove(menu);
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
