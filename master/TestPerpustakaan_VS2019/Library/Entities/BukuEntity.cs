using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestPerpustakaan_VS2019.Library.Entities
{
    public class BukuEntity
    {

        public class Buku
        {
            [Key]
            public long ID { get; set; }

            public string JudulBuku { get; set; }
            public string Pengarang { get; set; }
            public string JenisBuku { get; set; }
            public decimal HargaSewa { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }

        }
    }
}
