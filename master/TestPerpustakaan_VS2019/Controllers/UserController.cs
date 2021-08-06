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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

using System.Text;
using System.Text.Json.Serialization;

namespace TestPerpustakaan_VS2019.Controllers
{
    public class UserController : Controller
    {
        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;
        public SessionUtility session;

        //public UserManager<ApplicationUser> userManager;
        //public SignInManager<ApplicationUser> signInManager;

        public UserEntity.User userInfo;

        public UserController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
                              //UserManager<ApplicationUser> _userManager,
                              //SignInManager<ApplicationUser> _signInManager)
        {
            context = _context;
            hosting = _hosting;
            session = _session;

            //userManager = _userManager;
            //signInManager = _signInManager;
        }
        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult UserDetail()
        {

            return View();
        }

        private IEnumerable<string[]> GetListData(string isFilter,
                                                  string fullname, string email,
                                                  string isActive, string roleId,
                                                  bool isDownload)
        {

            UserRepository user = new UserRepository(context, hosting, session);
            MasterRepository master = new MasterRepository(context, hosting, session);
            RoleRepository role = new RoleRepository(context, hosting, session);

            IEnumerable<UserEntity.User> list = null;

            if (string.IsNullOrEmpty(isFilter) && string.IsNullOrEmpty(fullname) &&
                string.IsNullOrEmpty(email) && string.IsNullOrEmpty(isActive) &&
                string.IsNullOrEmpty(roleId))
            {
                list = user.GetList();
            }
            else
            {
                list = user.GetListByFilter(fullname, email, isActive, roleId);
            }

            int rowNo = 1;

            var displayedData = (from a in list.AsEnumerable()
                                 orderby a.CreatedDate descending
                                 select new string[]
                                 {
                                    isDownload ? "" : a.ID.ToString() + "," + a.UserName + "," + Encryption.Decrypt(a.Password) + "," +
                                                      a.Fullname + "," + a.Email + "," + a.IDLocation.ToString() + "," + a.IDRole+ "," + 
                                                      a.IsLogin + "," + (Convert.ToBoolean(a.IsActive) ? "True" : "False"),
                                    isDownload ? (rowNo++ - list.Count()).ToString() : "",
                                    a.UserName,
                                    a.Fullname,
                                    master.GetListLocationById(a.IDLocation).FirstOrDefault().LocationName,
                                    role.GetListById(a.IDRole).FirstOrDefault().RoleName,
                                    a.Email,
                                    a.LastLoginDate != null ? Convert.ToDateTime(a.LastLoginDate).ToString("dd-MMM-yyyy H:mm:ss") : "",
                                    Convert.ToBoolean(a.IsActive) ? "Active"  : "Inactive"
        });


            return displayedData;
        }
        public class jQueryDataTableParamModel
        {
            public int iColumns { get; set; }
            public int iDisplayLength { get; set; }
            public int iDisplayStart { get; set; }
            public int iSortingCols { get; set; }
            public string sColumns { get; set; }
            public string sEcho { get; set; }
            public string sSearch { get; set; }
        }
        public ActionResult AjaxHandlerUserList(jQueryDataTableParamModel param, string isFilter = "",
                                                string fullname = "", string email = "",
                                                string isActive = "", string roleId = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            var displayedData = GetListData(isFilter, fullname, email, isActive, roleId, false);
            int countData = displayedData.Count();

            // SORTING COLUMN
            Func<string[], string> orderFuncString = null;
            Func<string[], int> orderFuncInteger = null;

            int sortColumnIndex = Convert.ToInt32(Request.Query["iSortCol_0"]);
            var sortDirection = Request.Query["sSortDir_0"];

            if (sortColumnIndex > 0)
            {
                if (sortDirection == "asc")
                {

                    if (sortColumnIndex != 2)
                    {
                        orderFuncString = (x => x[sortColumnIndex].ToString());
                        displayedData = displayedData.OrderBy(orderFuncString);
                    }
                    else
                    {
                        //orderFuncInteger = (x => Convert.ToInt16(x[sortColumnIndex]));
                        //displayedData = displayedData.OrderBy(orderFuncInteger);
                    }
                }
                else
                {
                    if (sortColumnIndex != 2)
                    {
                        orderFuncString = (x => x[sortColumnIndex].ToString());
                        displayedData = displayedData.OrderByDescending(orderFuncString);
                    }
                    else
                    {
                        //orderFuncInteger = (x => Convert.ToInt16(x[sortColumnIndex]));
                        //displayedData = displayedData.OrderByDescending(orderFuncInteger);
                    }
                }
            }

            // DISPLAY LOADING PAGING
            displayedData = displayedData.Skip(param.iDisplayStart)
                                         .Take(param.iDisplayLength);

            result = displayedData.ToList();

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = countData,
                iTotalDisplayRecords = countData,
                aaData = result
            });
        }

        [HttpPost]
        public ActionResult AddEditUser(string id, string paramAll)
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            try
            {
                string[] iParams;
                iParams = paramAll.Split('~');

                string userName = iParams[0].ToString();
                string password = iParams[1].ToString();
                string confirmPass = iParams[2].ToString();
                string email = iParams[4].ToString();

                UserRepository user = new UserRepository(context, hosting, session);

                int countUserName = user.GetList().Where(x => x.UserName == userName.Trim()).Count();
                int countEmail = user.GetList().Where(x => x.Email == email.Trim()).Count();

                // is valid email
                bool isValidEmail = Functions.IsValidEmail(email);

                // is valid alpha numeric
                bool isValidAlphaNumeric = Functions.IsAlphaNumeric(password);

                // If data empty
                bool isFieldNull = false;
                for (int x = 1; x < iParams.Count() - 2; x++)
                {
                    if (string.IsNullOrEmpty(iParams[x].ToString()))
                    {
                        isFieldNull = true;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(id) && id != "0")
                {

                    string userNameEdit = user.GetListById(Convert.ToInt16(id)).FirstOrDefault().UserName;
                    string emailEdit = user.GetListById(Convert.ToInt16(id)).FirstOrDefault().Email;

                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (userNameEdit != userName && countUserName > 0)
                        result = new { error = 2 };
                    else if (!isValidAlphaNumeric)
                        result = new { error = 3 };
                    else if (password.Trim() != confirmPass.Trim())
                        result = new { error = 4 };
                    else if (emailEdit != email && countEmail > 0)
                        result = new { error = 5 };
                    else if (!isValidEmail)
                        result = new { error = 6 };
                    else
                    {
                        // Edit User
                        user.Update(GetPopulateData(id, paramAll));

                        result = new { error = "Edit" };
                    }
                }
                else
                {
                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (countUserName > 0)
                        result = new { error = 2 };
                    else if (!isValidAlphaNumeric)
                        result = new { error = 3 };
                    else if (password.Trim() != confirmPass.Trim())
                        result = new { error = 4 };
                    else if (countEmail > 0)
                        result = new { error = 5 };
                    else if (!isValidEmail)
                        result = new { error = 6 };
                    else
                    {
                        // Add User
                        user.Add(GetPopulateData(id, paramAll));

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

        private UserEntity.User GetPopulateData(string id, string paramAll)
        {

            string[] iParams;

            iParams = paramAll.Split('~');

            string userName = iParams[0].ToString();
            string password = iParams[1].ToString();
            string confirmPass = iParams[2].ToString();
            string fullname = iParams[3].ToString();
            string email = iParams[4].ToString();
            string locationId = iParams[5].ToString();
            string roleId = iParams[6].ToString();
            string isLogin = iParams[7].ToString();
            string isActive = iParams[8].ToString();

            userInfo = new UserEntity.User();

            if (!string.IsNullOrEmpty(id) && id != "0")
                userInfo.ID = Convert.ToInt16(id);

            userInfo.Code = roleId;
            userInfo.UserName = userName;
            userInfo.Password = Encryption.Encrypt(password);
            userInfo.Fullname = fullname;
            userInfo.Email = email;
            userInfo.IDLocation = Convert.ToInt16(locationId);
            userInfo.IDRole = Convert.ToInt16(roleId);
            userInfo.IsLogin = Convert.ToBoolean(isLogin);
            userInfo.IsActive = Convert.ToBoolean(isActive);

            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                UserRepository user = new UserRepository(context, hosting, session);

                userInfo.LastLoginDate = user.GetListById(Convert.ToInt16(id)).FirstOrDefault().LastLoginDate;
                userInfo.CreatedDate = user.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedDate;
                userInfo.CreatedBy = user.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedBy;
                userInfo.UpdatedDate = DateTime.Now;
                userInfo.UpdatedBy = session.GetSession("sesUserName").ToString();
            }
            else
            {
                userInfo.LastLoginDate = (DateTime?)null;
                userInfo.CreatedDate = DateTime.Now;
                userInfo.CreatedBy = session.GetSession("sesUserName").ToString();
                userInfo.UpdatedDate = (DateTime?)null;
                userInfo.UpdatedBy = null;
            }

            return userInfo;
        }

        [HttpGet]
        public ActionResult DeleteUser(string id = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            int userId = 0;
            object result = null;


            try
            {
                userId = Convert.ToInt16(id);

                UserRepository user = new UserRepository(context, hosting, session);
                user.Delete(userId);

                result = new { error = 0 };

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }    

        [HttpPost]
        public ActionResult GetLogin(string userName, string password)
        {

            object result = null;

            // Select Login By User and Password
            UserRepository user = new UserRepository(context, hosting, session);
            RoleRepository role = new RoleRepository(context, hosting, session);

            try
            {
                if (ModelState.IsValid)
                {
                    string encryptPassword = Encryption.Encrypt(password);

                    int countLoginAll = 0;
                    int countLoginActive = 0;
                    int countIsLogin = 0;

                    countLoginAll = user.GetList().Where(x => x.UserName.ToLower() == userName.ToLower().Trim() &&
                                                                x.Password == encryptPassword.Trim()).Count();


                    countLoginActive = user.GetList().Where(x => x.UserName.ToLower() == userName.ToLower().Trim() &&
                                                        x.Password == encryptPassword.Trim() &&
                                                        x.IsActive == true).Count();

                    countIsLogin = user.GetList().Where(x => x.UserName.ToLower() == userName.ToLower().Trim() &&
                                                        x.Password == encryptPassword.Trim() &&
                                                        x.IsActive == true &&
                                                        x.IsLogin == true).Count();


                    // If password not null
                    if (countLoginAll > 0)
                    {
                        // if IsLogin null
                        if (countIsLogin == 0)
                        {

                            // If User is active
                            if (countLoginActive > 0)
                            {

                                session.SetSession("sesUserName", userName);

                                result = new { error = 0 };

                                // Using Identity User
                                //var userMan = userManager.FindByNameAsync(userName);

                                //if (userMan != null)
                                //{
                                //    var userSignIn = signInManager.PasswordSignInAsync(userName, password, false, false); 

                                //    if (userSignIn.Result.Succeeded)
                                //    {

                                //        session.SetSession("sesUserName", userName);

                                //        result = new { error = 0 };

                                //    }
                                //}

           
                            }
                            else
                                result = new { error = 3 };
                        }
                        else
                            result = new { error = 2 };
                    }
                    else
                        result = new { error = 1 };

                }

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }   

            return Json(result);

        }


        [HttpGet]
        public ActionResult GetLogout()
        {

            object result = null;       

            // Remove Session 
            session.SetSession("sesUserName", "");
            session.RemoveSession("sesUserName");

            result = new { error = 0 };

            return Json(result);
        }


        [HttpGet]
        public ActionResult GeneratePassword()
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            try
            {
                string randomPassword = PasswordGeneratorV2.getPassword(8);

                result = new { value = randomPassword };
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }




    }
}
