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

using System.Text;
using System.Text.Json.Serialization;

namespace TestPerpustakaan_VS2019.Controllers
{
    public class ReportsController : Controller
    {
        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;
        public SessionUtility session;

        public PeminjamanEntity.Peminjaman peminjamanInfo;

        public ReportsController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                                SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }
        public IActionResult PeminjamanList()
        {
            return View();
        }

        public IActionResult PeminjamanDetail()
        {

            return View();
        }

        private IEnumerable<string[]> GetListData(string isFilter, string judulBuku,
                                                  bool isDownload)
        {

            PeminjamanRepository Peminjaman = new PeminjamanRepository(context, hosting, session);
            UserRepository user = new UserRepository(context, hosting, session);
            RoleRepository role = new RoleRepository(context, hosting, session);

            IEnumerable<PeminjamanEntity.Peminjaman> list = null;

            list = Peminjaman.GetList();

            string userName = session.GetSession("sesUserName").ToString();
            long userId = user.GetList().Where(x => x.UserName == userName.Trim()).FirstOrDefault().ID;

            long roleId = user.GetList().Where(x => x.UserName == userName.Trim()).FirstOrDefault().IDRole;
            string roleName = role.GetList().Where(x => x.ID == Convert.ToInt16(roleId)).FirstOrDefault().RoleName;

            // If Role = Penyewa
            if (roleName.ToLower() == EnumCollection.RoleName.Penyewa.ToLower())
            {
                list = list.Where(x => x.IDUser == userId);
            }

            if (!string.IsNullOrEmpty(judulBuku))
            {
                list = (from a in list
                        join b in context.Bukus on a.IDBuku equals b.ID
                        where b.JudulBuku.ToLower().Contains(judulBuku.ToLower())
                        select a).ToList();
            }


            int rowNo = 1;

            var displayedData = (from a in list.AsEnumerable()
                                 join b in context.Bukus on a.IDBuku equals b.ID
                                 orderby a.CreatedDate descending
                                 select new string[]
                                 {

                                    isDownload ? (rowNo++ - list.Count()).ToString() : "",
                                    b.JudulBuku,
                                    b.Pengarang,
                                    b.JenisBuku,
                                    Functions.ParseDecimalWithComma(b.HargaSewa),
                                    (a.TanggalSelesai - a.TanggalMulai).ToString().Replace(".00:00:00",""),
                                    Functions.ParseDecimalWithComma(a.TotalSewa)

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
        public ActionResult AjaxHandlerRepPinjamList(jQueryDataTableParamModel param, string isFilter = "",
                                                     string judulBuku = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            var displayedData = GetListData(isFilter, judulBuku, false);
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

                    if (sortColumnIndex != 1)
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
                    if (sortColumnIndex != 1)
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

        [HttpGet]
        public IActionResult DownloadRepPinjam(string isFilter = "", string judulBuku = "",
                                               string columnData = "", string footerData = "")
        {
            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");


            var displayedData = GetListData(isFilter, judulBuku, true);
            int countData = displayedData.Count();

            StringBuilder sb = new StringBuilder();

            // Column Data
            string[] listColumn = columnData.Split('~');

            string columnName = string.Join("\t", listColumn.ToArray());
            sb.AppendLine(columnName);

            // Row Data
            if (countData > 0)
            {
                List<string> listRow = new List<string>();
                string rowData = "";

                foreach (var item in displayedData)
                {

                    for (int x = 0; x < listColumn.Count(); x++)
                    {

                        if (item[x] is null) break;

                        rowData = rowData + item[x].ToString() + "\t";

                    }

                    listRow.Add(rowData);
                    rowData = "";
                }

                foreach (var item in listRow)
                {
                    sb.AppendLine(item);
                }
            }

            // Footer Data
            string[] listFooter = footerData.Split('~');

            string footerName = string.Join("\t", listFooter.ToArray());
            sb.AppendLine(footerName);


            string fileName = "PeminjamanBukuList_" + DateTime.Now.ToString("dd-MMM-yyyy HHmmss") + ".xls";

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "application/excel", fileName);
        }

      


    }
}
