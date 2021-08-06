using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestPerpustakaan_VS2019.Library.Entities
{
    public class PeminjamanEntity
    {

        public class Peminjaman
        {
            [Key]
            public long ID { get; set; }

            public long IDUser { get; set; }
            public long IDBuku { get; set; }
            public DateTime? TanggalMulai { get; set; }
            public DateTime? TanggalSelesai { get; set; }
            public decimal TotalSewa { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }

        }
    }
}
