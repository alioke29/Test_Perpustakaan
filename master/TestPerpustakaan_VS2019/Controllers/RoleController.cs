using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Web;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

using TestPerpustakaan_VS2019.Models;

using TestPerpustakaan_VS2019.Library;
using TestPerpustakaan_VS2019.Library.DataAccess;
using TestPerpustakaan_VS2019.Library.Entities;
using TestPerpustakaan_VS2019.Library.Utilities;

using Microsoft.EntityFrameworkCore;

using System.Net.Http;
using System.Net.Http.Headers;

namespace TestPerpustakaan_VS2019.Controllers
{
    public class RoleController : Controller
    {
        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;
        public SessionUtility session;
        public RoleController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                                 SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        public RoleEntity.Role roleInfo;
        public IActionResult RoleList()
        {

            return View();
        }

        public IActionResult RoleDetail()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddEditRole(string id, string paramAll)
        {
            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            try
            {
                string[] iParams;
                iParams = paramAll.Split('~');

                string roleName = iParams[0].ToString();

                RoleRepository role = new RoleRepository(context, hosting, session);

                int countRoleName = role.GetList().Where(x => x.RoleName == roleName.Trim()).Count();

                // If data empty
                bool isFieldNull = false;
                for (int x = 0; x < iParams.Count() ; x++)
                {
                    if (string.IsNullOrEmpty(iParams[x].ToString()))
                    {
                        isFieldNull = true;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(id) && id != "0")
                {

                    string roleNameEdit = role.GetListById(Convert.ToInt16(id)).FirstOrDefault().RoleName;

                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (roleNameEdit != roleName && countRoleName > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Edit Role
                        role.Update(GetPopulateData(id, paramAll));

                        result = new { error = "Edit" };
                    }
                }
                else
                {
                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (countRoleName > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Add Role
                        role.Add(GetPopulateData(id, paramAll));

                        result = new { error = "Add" };
                    }
                }

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }

        private RoleEntity.Role GetPopulateData(string id, string paramAll)
        {

            string[] iParams;

            iParams = paramAll.Split('~');

            string roleName = iParams[0].ToString();
            string desc = iParams[1].ToString();

            roleInfo = new RoleEntity.Role();

            if (!string.IsNullOrEmpty(id) && id != "0")
                roleInfo.ID = Convert.ToInt16(id);

            roleInfo.RoleName = roleName;
            roleInfo.Desc = desc;

            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                RoleRepository role = new RoleRepository(context, hosting, session);

                roleInfo.CreatedDate = role.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedDate;
                roleInfo.CreatedBy = role.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedBy;
                roleInfo.UpdatedDate = DateTime.Now;
                roleInfo.UpdatedBy = session.GetSession("sesUserName").ToString();
            }
            else
            {
                roleInfo.CreatedDate = DateTime.Now;
                roleInfo.CreatedBy = session.GetSession("sesUserName").ToString();
                roleInfo.UpdatedDate = (DateTime?)null;
                roleInfo.UpdatedBy = null;
            }

            return roleInfo;
        }

        [HttpGet]
        public ActionResult DeleteRole(string id = "")
        {
            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            int roleId = 0;
            object result = null;

            try
            {
                roleId = Convert.ToInt16(id);

                // Check in user table
                UserRepository user = new UserRepository(context, hosting, session);

                IEnumerable<UserEntity.User> list = user.GetList();

                int countUser = list.Where(x => x.IDRole == roleId).Count();

                if (countUser > 0)
                    result = new { error = 1 };
                else
                {

                    RoleRepository role = new RoleRepository(context, hosting, session);
                    role.Delete(roleId);

                    result = new { error = 0 };
                }

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }


    }
}
