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
    public class BukuRepository 
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;

        public BukuRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                              SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }


        public List<BukuEntity.Buku> GetList()
        {

            List<BukuEntity.Buku> result = null;

            try
            {
                result = (from row in context.Bukus
                          select new BukuEntity.Buku
                          {
                              ID = row.ID,
                              JudulBuku = row.JudulBuku,
                              Pengarang = row.Pengarang,
                              JenisBuku = row.JenisBuku,
                              HargaSewa = row.HargaSewa,
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

        public List<BukuEntity.Buku> GetListById(int id)
        {

            List<BukuEntity.Buku> result = null;

            try
            {
                result = (from row in context.Bukus
                          where row.ID == id
                          select new BukuEntity.Buku
                          {
                              ID = row.ID,
                              JudulBuku = row.JudulBuku,
                              Pengarang = row.Pengarang,
                              JenisBuku = row.JenisBuku,
                              HargaSewa = row.HargaSewa,
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

        public List<BukuEntity.Buku> GetListByFilter(string judulBuku)
        {
            List<BukuEntity.Buku> result = null;

            try
            {
                result = (from row in context.Bukus
                          select new BukuEntity.Buku
                          {
                              ID = row.ID,
                              JudulBuku = row.JudulBuku,
                              Pengarang = row.Pengarang,
                              JenisBuku = row.JenisBuku,
                              HargaSewa = row.HargaSewa,
                              CreatedDate = row.CreatedDate,
                              CreatedBy = row.CreatedBy,
                              UpdatedDate = row.UpdatedDate,
                              UpdatedBy = row.UpdatedBy
                          }).ToList();

                if (!string.IsNullOrEmpty(judulBuku))
                    result = result.Where(x => x.JudulBuku.ToLower().Contains(judulBuku.ToLower())).ToList();

            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result;
        }

        public object Add(BukuEntity.Buku Buku)
        {

            object result = null;

            try
            {
                result = context.Bukus.Add(Buku);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public object Update(BukuEntity.Buku buku)
        {

            object result = null;

            try
            {

                var BukuEntity = context.Bukus.FirstOrDefault(x => x.ID == buku.ID);               

                BukuEntity.JudulBuku = buku.JudulBuku;
                BukuEntity.Pengarang = buku.Pengarang;
                BukuEntity.JenisBuku = buku.JenisBuku;
                BukuEntity.HargaSewa = buku.HargaSewa;
                BukuEntity.CreatedDate = buku.CreatedDate;
                BukuEntity.CreatedBy = buku.CreatedBy;
                BukuEntity.UpdatedDate = buku.UpdatedDate;
                BukuEntity.UpdatedBy = buku.UpdatedBy;
                context.Bukus.UpdateRange(BukuEntity);
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

            BukuEntity.Buku buku = new BukuEntity.Buku();
            object result = null;

            try
            {
                buku.ID = id;
                result = context.Bukus.Remove(buku);
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
