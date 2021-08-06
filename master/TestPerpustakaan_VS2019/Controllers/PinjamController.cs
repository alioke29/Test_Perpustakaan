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
    public class PinjamController : Controller
    {
        public IWebHostEnvironment hosting;
        public ApplicationDbContext context;
        public SessionUtility session;

        public PeminjamanEntity.Peminjaman peminjamanInfo;

        public PinjamController(ApplicationDbContext _context, IWebHostEnvironment _hosting,
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

            PeminjamanRepository peminjaman = new PeminjamanRepository(context, hosting, session);
            UserRepository user = new UserRepository(context, hosting, session);
            RoleRepository role = new RoleRepository(context, hosting, session);

            IEnumerable<PeminjamanEntity.Peminjaman> list = null;

            list = peminjaman.GetList();

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

                                    isDownload ? "" : a.ID.ToString() + "," + a.IDBuku.ToString() + "," + b.JudulBuku + "," +
                                                      b.Pengarang + "," + b.JenisBuku + "," + b.HargaSewa + "," +
                                                      Convert.ToDateTime(a.TanggalMulai).ToString("MM/dd/yyyy") + "," +
                                                      Convert.ToDateTime(a.TanggalSelesai).ToString("MM/dd/yyyy") + "," +
                                                      a.TotalSewa,
                                    isDownload ? (rowNo++ - list.Count()).ToString() : "",
                                    b.JudulBuku,
                                    b.Pengarang,
                                    b.JenisBuku,
                                    Functions.ParseDecimalWithComma(b.HargaSewa),
                                    Convert.ToDateTime(a.TanggalMulai).ToString("dd-MMM-yyyy"),
                                    Convert.ToDateTime(a.TanggalSelesai).ToString("dd-MMM-yyyy"),
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
        public ActionResult AjaxHandlerPinjamList(jQueryDataTableParamModel param, string isFilter = "",
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
        public IActionResult DownloadPinjam(string isFilter = "", string judulBuku = "",
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

            string fileName = "PeminjamanBukuList_" + DateTime.Now.ToString("dd-MMM-yyyy HHmmss") + ".xls";

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "application/excel", fileName);
        }

        [HttpPost]
        public ActionResult AddEditPinjam(string id, string paramAll)
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;

            try
            {
                string[] iParams;
                iParams = paramAll.Split('~');

                string idBuku = iParams[0].ToString();

                PeminjamanRepository peminjaman = new PeminjamanRepository(context, hosting, session);

                int countIdBuku = 0;
                  
                if (!string.IsNullOrEmpty(idBuku))
                    countIdBuku = peminjaman.GetList().Where(x => x.IDBuku == Convert.ToInt16(idBuku)).Count();


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

                    long idBukuEdit = peminjaman.GetListById(Convert.ToInt16(id)).FirstOrDefault().IDBuku;

                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (idBukuEdit != Convert.ToInt16(idBuku) && countIdBuku > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Edit Peminjaman
                        peminjaman.Update(GetPopulateData(id, paramAll));

                        result = new { error = "Edit" };
                    }
                }
                else
                {
                    if (isFieldNull)
                        result = new { error = 1 };
                    else if (countIdBuku > 0)
                        result = new { error = 2 };
                    else
                    {
                        // Add Peminjaman
                        peminjaman.Add(GetPopulateData(id, paramAll));

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

        private PeminjamanEntity.Peminjaman GetPopulateData(string id, string paramAll)
        {

            string[] iParams;

            iParams = paramAll.Split('~');

            string idBuku = iParams[0].ToString();
            string tanggalMulai = iParams[1].ToString();
            string tanggalSelesai = iParams[2].ToString();
            string totalSewa = iParams[3].ToString();

            peminjamanInfo = new PeminjamanEntity.Peminjaman();

            if (!string.IsNullOrEmpty(id) && id != "0")
                peminjamanInfo.ID = Convert.ToInt16(id);

            UserRepository user = new UserRepository(context, hosting, session);

            string username = session.GetSession("sesUserName").ToString();
            peminjamanInfo.IDUser = user.GetList().Where(x => x.UserName == username.Trim()).FirstOrDefault().ID;

            peminjamanInfo.IDBuku = Convert.ToInt16(idBuku);
            peminjamanInfo.TanggalMulai = Convert.ToDateTime(tanggalMulai);
            peminjamanInfo.TanggalSelesai = Convert.ToDateTime(tanggalSelesai);
            peminjamanInfo.TotalSewa = !string.IsNullOrEmpty(totalSewa) ? Convert.ToDecimal(totalSewa) : 0;


            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                PeminjamanRepository peminjaman = new PeminjamanRepository(context, hosting, session);

                peminjamanInfo.CreatedDate = peminjaman.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedDate;
                peminjamanInfo.CreatedBy = peminjaman.GetListById(Convert.ToInt16(id)).FirstOrDefault().CreatedBy;
                peminjamanInfo.UpdatedDate = DateTime.Now;
                peminjamanInfo.UpdatedBy = session.GetSession("sesUserName").ToString();
            }
            else
            {
                peminjamanInfo.CreatedDate = DateTime.Now;
                peminjamanInfo.CreatedBy = session.GetSession("sesUserName").ToString();
                peminjamanInfo.UpdatedDate = (DateTime?)null;
                peminjamanInfo.UpdatedBy = null;
            }

            return peminjamanInfo;
        }

        [HttpGet]
        public ActionResult DeletePinjam(string id = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            int pinjamId = 0;
            object result = null;


            try
            {
                pinjamId = Convert.ToInt16(id);

                PeminjamanRepository Peminjaman = new PeminjamanRepository(context, hosting, session);
                Peminjaman.Delete(pinjamId);

                result = new { error = 0 };

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return Json(result);
        }


        [HttpGet]
        public IActionResult GetBukuById(string id = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            BukuEntity.Buku buku = new BukuEntity.Buku();

            string bukuId = id;
            buku = context.Bukus.Where(x => x.ID == Convert.ToInt16(bukuId)).FirstOrDefault();

            return Json(buku);

        }

        [HttpGet]
        public IActionResult GetTotalSewa(string tanggalMulai = "", string tanggalSelesai = "", 
                                          string hargaSewa = "")
        {

            if (session.GetSession("sesUserName") == null)
                return View("ErrorPage/ErrorDetail");

            object result = null;
            
            DateTime tanggalMulaiDate = Convert.ToDateTime(tanggalMulai);
            DateTime tanggalSelesaiDate = Convert.ToDateTime(tanggalSelesai);
            decimal hargaSewaNumeric = Convert.ToDecimal(hargaSewa);

            TimeSpan difference = tanggalSelesaiDate - tanggalMulaiDate;
            decimal days = Convert.ToDecimal(difference.TotalDays);

            decimal totalSewa = days * hargaSewaNumeric;

            result = new { TotalSewa = Functions.ParseDecimalWithComma(totalSewa) };

            return Json(result);

        }


    }
}
