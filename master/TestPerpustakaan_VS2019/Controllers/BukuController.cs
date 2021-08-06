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
    public class BukuController : Controller
    {
        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;
        public SessionUtility session;

        public BukuEntity.Buku bukuInfo;

        public BukuController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }
        public IActionResult BukuList()
        {
            return View();
        }

        public IActionResult BukuDetail()
        {

            return View();
        }

        private IEnumerable<string[]> GetListData(string isFilter, string judulBuku,
                                                  bool isDownload)
        {

            BukuRepository buku = new BukuRepository(context, hosting, session);

            IEnumerable<BukuEntity.Buku> list = null;

            if (string.IsNullOrEmpty(isFilter) && string.IsNullOrEmpty(judulBuku))
            {
                list = buku.GetList();
            }
            else
            {
                list = buku.GetListByFilter(judulBuku);
            }

            int rowNo = 1;

            var displayedData = (from a in list.AsEnumerable()
                                 orderby a.JudulBuku
                                 select new string[]
                                 {
                                    isDownload ? "" : a.ID.ToString() + "," + a.JudulBuku + "," + a.Pengarang + "," +
                                                      a.JenisBuku + "," + a.HargaSewa,
                                    isDownload ? (rowNo++ - list.Count()).ToString() : "",
                                    a.ID.ToString(),
                                    a.JudulBuku,
                                    a.Pengarang,
                                    a.JenisBuku,
                                    Functions.ParseDecimalWithComma(a.HargaSewa)
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
        public ActionResult AjaxHandlerBukuList(jQueryDataTableParamModel param, string isFilter = "",
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
                        orderFuncInteger = (x => Convert.ToInt16(x[sortColumnIndex]));
                        displayedData = displayedData.OrderBy(orderFuncInteger);
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
                        orderFuncInteger = (x => Convert.ToInt16(x[sortColumnIndex]));
                        displayedData = displayedData.OrderByDescending(orderFuncInteger);
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
        public IActionResult DownloadBuku(string isFilter = "", string judulBuku = "",
                                          string columnData = "")
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

            string fileName = "BukuList_" + DateTime.Now.ToString("dd-MMM-yyyy HHmmss") + ".xls";

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "application/excel", fileName);
        }

        [HttpPost]
        public ActionResult AddEditBuku(string id, string paramAll)
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            try
            {
                string[] iParams;
                iParams = paramAll.Split('~');

                string judulBuku = iParams[0].ToString();
                string pengarang = iParams[1].ToString();
                string jenisBuku = iParams[2].ToString();
                string hargaSewa = iParams[3].ToString();

                BukuRepository buku = new BukuRepository(context, hosting, session);

                int countJudulBuku = buku.GetList().Where(x => x.JudulBuku == judulBuku.Trim()).Count();

                // If data empty
                bool isFieldNull = false;
                for (int x = 0; x < iParams.Count() - 1; x++)
                {
                    if (string.IsNullOrEmpty(iParams[x].ToString()))
                    {
                        isFieldNull = true;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(id) && id != "0")
                {

                    string judulBukuEdit = buku.GetListById(Convert.ToInt16(id)).FirstOrDefault().JudulBuku;


                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (judulBukuEdit != judulBuku && countJudulBuku > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Edit Buku
                        buku.Update(GetPopulateData(id, paramAll));

                        result = new { error = "Edit" };
                    }
                }
                else
                {
                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (countJudulBuku > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Add Buku
                        buku.Add(GetPopulateData(id, paramAll));

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

        private BukuEntity.Buku GetPopulateData(string id, string paramAll)
        {

            string[] iParams;

            iParams = paramAll.Split('~');

            string judulBuku = iParams[0].ToString();
            string pengarang = iParams[1].ToString();
            string jenisBuku = iParams[2].ToString();
            string hargaSewa = iParams[3].ToString();

            bukuInfo = new BukuEntity.Buku();

            if (!string.IsNullOrEmpty(id) && id != "0")
                bukuInfo.ID = Convert.ToInt16(id);

            bukuInfo.JudulBuku = judulBuku;
            bukuInfo.Pengarang = pengarang;
            bukuInfo.JenisBuku = jenisBuku;
            bukuInfo.HargaSewa = Convert.ToDecimal(hargaSewa);


            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                BukuRepository buku = new BukuRepository(context, hosting, session);

                bukuInfo.CreatedDate = buku.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedDate;
                bukuInfo.CreatedBy = buku.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedBy;
                bukuInfo.UpdatedDate = DateTime.Now;
                bukuInfo.UpdatedBy = session.GetSession("sesUserName").ToString();
            }
            else
            {
                bukuInfo.CreatedDate = DateTime.Now;
                bukuInfo.CreatedBy = session.GetSession("sesUserName").ToString();
                bukuInfo.UpdatedDate = (DateTime?)null;
                bukuInfo.UpdatedBy = null;
            }

            return bukuInfo;
        }

        [HttpGet]
        public ActionResult DeleteBuku(string id = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            int bukuId = 0;
            object result = null;


            try
            {
                bukuId = Convert.ToInt16(id);

                BukuRepository buku = new BukuRepository(context, hosting, session);
                buku.Delete(bukuId);

                result = new { error = 0 };

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }    

       

    }
}
