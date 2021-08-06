using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestPerpustakaan_VS2019.Library.Entities
{
    public class LocationEntity
    {

        public class Location
        {
            [Key]
            public long ID { get; set; }
            public string Code { get; set; }
            public string LocationName { get; set; }
            public string Desc { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }

        }

    }
}
