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
    public class PeminjamanRepository
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;

        public PeminjamanRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                                   SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        public IEnumerable<PeminjamanEntity.Peminjaman> GetList()
        {

            IEnumerable<PeminjamanEntity.Peminjaman> result = null;

            try
            {
                result = (from row in context.Peminjamans
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }

        public IEnumerable<PeminjamanEntity.Peminjaman> GetListById(long id)
        {

            IEnumerable<PeminjamanEntity.Peminjaman> result = null;

            try
            {
                result = (from row in context.Peminjamans
                          where row.ID == id
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }

        public object Add(PeminjamanEntity.Peminjaman peminjaman)
        {

            object result = null;

            try
            {
                result = context.Peminjamans.Add(peminjaman);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Update(PeminjamanEntity.Peminjaman peminjaman)
        {

            object result = null;


            try
            {

                var peminjamanEntity = context.Peminjamans.FirstOrDefault(item => item.ID == peminjaman.ID);

                peminjamanEntity.IDUser = peminjaman.IDUser;
                peminjamanEntity.IDBuku = peminjaman.IDBuku;
                peminjamanEntity.TanggalMulai = peminjaman.TanggalMulai;
                peminjamanEntity.TanggalSelesai = peminjaman.TanggalSelesai;
                peminjamanEntity.TotalSewa = peminjaman.TotalSewa;
                peminjamanEntity.CreatedDate = peminjaman.CreatedDate;
                peminjamanEntity.CreatedBy = peminjaman.CreatedBy;
                peminjamanEntity.UpdatedDate = peminjaman.UpdatedDate;
                peminjamanEntity.UpdatedBy = peminjaman.UpdatedBy;
                context.Peminjamans.UpdateRange(peminjamanEntity);
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

            PeminjamanEntity.Peminjaman peminjaman = new PeminjamanEntity.Peminjaman();
            object result = null;

            try
            {
                peminjaman.ID = id;
                result = context.Peminjamans.Remove(peminjaman);
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
