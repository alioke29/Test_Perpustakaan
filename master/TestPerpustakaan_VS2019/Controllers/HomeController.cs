using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

using TestPerpustakaan_VS2019.Models;

using TestPerpustakaan_VS2019.Library;
using TestPerpustakaan_VS2019.Library.DataAccess;
using TestPerpustakaan_VS2019.Library.Utilities;
using TestPerpustakaan_VS2019.Library.Entities;

using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Text;

namespace TestPerpustakaan_VS2019.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;
        public HomeController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        public IActionResult GetLogoutIfSessionNull()
        {

            return Redirect("~/Login/Index");
        }

        private object GetMenuList()
        {
            object result = null;

            try
            {

                //session.SetSession("sesUserName", "admin");


                if (session.GetSession("sesUserName") != null)
                {

                    string sesUserName = session.GetSession("sesUserName").ToString();

                    UserRepository user = new UserRepository(context, hosting, session);
                    RoleRepository role = new RoleRepository(context, hosting, session);

                    string userId = "";
                    string roleId = "";
                    string fullname = "";
                    string roleName = "";

                    userId = user.GetList().Where(x => x.UserName.ToLower() == sesUserName.ToLower()).FirstOrDefault().ID.ToString();
                        
                    roleId = user.GetList().Where(x => x.UserName.ToLower() == sesUserName.ToLower()).FirstOrDefault().IDRole.ToString();
                    roleName = role.GetList().Where(x => x.ID == Convert.ToInt16(roleId)).FirstOrDefault().RoleName;
                    fullname = user.GetList().Where(x => x.UserName.ToLower() == sesUserName.ToLower()).FirstOrDefault().Fullname;

                    // Get Name into Header
                    ViewData["vdHeaderName"] = fullname;
                    ViewData["vdHeaderNameAs"] = roleName;

                    // Update Is Login = true
                    UserEntity.User userEntity = new UserEntity.User();

                    userEntity.ID = Convert.ToInt16(userId);
                    userEntity.IsLogin = false; //  true (not active)
                    userEntity.LastLoginDate = DateTime.Now; 
                    user.UpdateIsLogin(userEntity);


                    // Select Menu By Role Id                  
                    MenuRepository menu = new MenuRepository(context, hosting, session);

                    IEnumerable<MenuEntity.Menu> list = menu.GetListMenuByRole(Convert.ToInt16(roleId));

                    result = list;
                }
                else
                {
                    ViewData["vdHeaderName"] = null;

                    return GetLogoutIfSessionNull();
                }

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public void GetTreviewExpand(string menuCode, string subMenuCode)
        {

            // Treeview control
            ViewData["vdTreeviewMenuCode"] = menuCode;
            ViewData["vdTreeviewSubMenuCode"] = subMenuCode;

            // Set Session
            HttpContext.Session.SetString("sesMenuCode", menuCode);
            HttpContext.Session.SetString("sesSubMenuCode", subMenuCode);
        }
        public void GetMenuRootInfo(string menuCode, string subMenuCode)
        {
            // Menu Root Info

            MenuRepository menu = new MenuRepository(context, hosting, session);
            IEnumerable<MenuEntity.Menu> list = menu.GetListMenuByParentAndMenuCode(menuCode, subMenuCode);

            ViewData["vdParentName"] = menu.GetListByCode(menuCode).FirstOrDefault().DisplayName;
            ViewData["vdDisplayName"] = list.FirstOrDefault().DisplayName;
        }

        public IActionResult Index()
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            return View(GetMenuList());
        }


        // USER Section
        public IActionResult UserList(string code = "", string isFilter = "",
                                      string fullname = "", string email = "",
                                      string isActive = "", string roleId = "")
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            try
            {

                ViewData["vdFullname"] = fullname;
                ViewData["vdEmail"] = email;
                ViewData["vdStatus"] = isActive;
                ViewData["vdRole"] = roleId;

                // Location List
                object resultLocation = null;

                MasterRepository master = new MasterRepository(context, hosting, session);

                IEnumerable<LocationEntity.Location> listLocation = master.GetListLocation();
                resultLocation = listLocation;

                ViewData["vdLocationList"] = resultLocation;

                // Role List
                object resultRole = null;

                RoleRepository role = new RoleRepository(context, hosting, session);

                IEnumerable<RoleEntity.Role> listRole = role.GetList();
                resultRole = listRole.OrderBy(x => Convert.ToInt16(x.ID)).ToList();

                ViewData["vdRoleList"] = resultRole;


                // Treeview control
                string menuCode = string.Empty;
                string subMenuCode = string.Empty;

                if (!string.IsNullOrEmpty(code))
                {
                    string[] paramAll = code.Split('_');
                    menuCode = paramAll[0].ToString();
                    subMenuCode = paramAll[1].ToString();
                }
                else
                {
                    menuCode = HttpContext.Session.GetString("sesMenuCode");
                    subMenuCode = HttpContext.Session.GetString("sesSubMenuCode");
                }

                GetTreviewExpand(menuCode, subMenuCode);
                GetMenuRootInfo(menuCode, subMenuCode);

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
                return View("ErrorPage/ErrorDetail", GetMenuList());
            }

            return View("User/UserList", GetMenuList());
        }

        // ROLE Section
        public IActionResult RoleList(string code = "", string isFilter = "",
                                      string roleName = "")
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            try
            {

                object result = null;
                RoleRepository role = new RoleRepository(context, hosting, session);

                if (string.IsNullOrEmpty(isFilter) && string.IsNullOrEmpty(roleName))
                {

                    IEnumerable<RoleEntity.Role> list = role.GetList();
                    result = list.OrderBy(x => Convert.ToInt16(x.ID)).ToList(); ;
                    ViewData["vdRoleList"] = result;
                }
                else
                {

                    IEnumerable<RoleEntity.Role> list = role.GetListByFilter(roleName);
                    result = list;
                    ViewData["vdRoleList"] = result;

                    ViewData["vdRoleName"] = roleName;
                }


                // Treeview control
                string menuCode = string.Empty;
                string subMenuCode = string.Empty;

                if (!string.IsNullOrEmpty(code))
                {
                    string[] paramAll = code.Split('_');
                    menuCode = paramAll[0].ToString();
                    subMenuCode = paramAll[1].ToString();
                }
                else
                {
                    menuCode = HttpContext.Session.GetString("sesMenuCode");
                    subMenuCode = HttpContext.Session.GetString("sesSubMenuCode");
                }

                GetTreviewExpand(menuCode, subMenuCode);
                GetMenuRootInfo(menuCode, subMenuCode);

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
                return View("ErrorPage/ErrorDetail", GetMenuList());
            }

            return View("Role/RoleList", GetMenuList());
        }


        // BUKU Section
        public IActionResult BukuList(string code = "", string isFilter = "", string judulBuku = "")
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            try
            {

                ViewData["vdJudulBukuFilter"] = judulBuku;


                // Buku List
                object resultBuku = null;

                BukuRepository buku = new BukuRepository(context, hosting, session);

                IEnumerable<BukuEntity.Buku> listBuku = buku.GetList();
                resultBuku = listBuku.OrderBy(x => Convert.ToInt16(x.ID)).ToList();

                ViewData["vdBukuList"] = resultBuku;


                // Treeview control
                string menuCode = string.Empty;
                string subMenuCode = string.Empty;

                if (!string.IsNullOrEmpty(code))
                {
                    string[] paramAll = code.Split('_');
                    menuCode = paramAll[0].ToString();
                    subMenuCode = paramAll[1].ToString();
                }
                else
                {
                    menuCode = HttpContext.Session.GetString("sesMenuCode");
                    subMenuCode = HttpContext.Session.GetString("sesSubMenuCode");
                }

                GetTreviewExpand(menuCode, subMenuCode);
                GetMenuRootInfo(menuCode, subMenuCode);


            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
                return View("ErrorPage/ErrorDetail", GetMenuList());
            }

            return View("Buku/BukuList", GetMenuList());
        }

        // PINJAM Section
        public IActionResult PinjamList(string code = "", string isFilter = "", string judulBuku = "")
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            try
            {

                ViewData["vdJudulBukuFilter"] = judulBuku;


                // Buku List
                object resultBuku = null;

                BukuRepository buku = new BukuRepository(context, hosting, session);

                IEnumerable<BukuEntity.Buku> listBuku = buku.GetList();
                resultBuku = listBuku.OrderBy(x => Convert.ToInt16(x.ID)).ToList();

                ViewData["vdBukuList"] = resultBuku;


                // Treeview control
                string menuCode = string.Empty;
                string subMenuCode = string.Empty;

                if (!string.IsNullOrEmpty(code))
                {
                    string[] paramAll = code.Split('_');
                    menuCode = paramAll[0].ToString();
                    subMenuCode = paramAll[1].ToString();
                }
                else
                {
                    menuCode = HttpContext.Session.GetString("sesMenuCode");
                    subMenuCode = HttpContext.Session.GetString("sesSubMenuCode");
                }

                GetTreviewExpand(menuCode, subMenuCode);
                GetMenuRootInfo(menuCode, subMenuCode);


            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
                return View("ErrorPage/ErrorDetail", GetMenuList());
            }

            return View("Pinjam/PinjamList", GetMenuList());
        }

        // REPORT PINJAM Section
        public IActionResult RepPinjamList(string code = "", string isFilter = "", string judulBuku = "")
        {

            if (session.GetSession("sesUserName") == null)
                return GetLogoutIfSessionNull();

            try
            {

                ViewData["vdJudulBukuFilter"] = judulBuku;


                // Treeview control
                string menuCode = string.Empty;
                string subMenuCode = string.Empty;

                if (!string.IsNullOrEmpty(code))
                {
                    string[] paramAll = code.Split('_');
                    menuCode = paramAll[0].ToString();
                    subMenuCode = paramAll[1].ToString();
                }
                else
                {
                    menuCode = HttpContext.Session.GetString("sesMenuCode");
                    subMenuCode = HttpContext.Session.GetString("sesSubMenuCode");
                }

                GetTreviewExpand(menuCode, subMenuCode);
                GetMenuRootInfo(menuCode, subMenuCode);


            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
                return View("ErrorPage/ErrorDetail", GetMenuList());
            }

            return View("Reports/RepPinjamList", GetMenuList());
        }

    }
}
