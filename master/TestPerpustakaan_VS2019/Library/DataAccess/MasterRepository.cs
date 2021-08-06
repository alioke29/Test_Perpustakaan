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
    public class MasterRepository
    {
        public ApplicationDbContext context;
        public IWebHostEnvironment hosting;
        public SessionUtility session;
        public MasterRepository(ApplicationDbContext _context, IWebHostEnvironment _hosting,
                           SessionUtility _session)
        {
            context = _context;
            hosting = _hosting;
            session = _session;
        }

        // GET LOCATION
        public IEnumerable<LocationEntity.Location> GetListLocation()
        {

            IEnumerable<LocationEntity.Location> result = null;

            try
            {
                result = (from row in context.Locations
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }
        public IEnumerable<LocationEntity.Location> GetListLocationById(long id)
        {

            IEnumerable<LocationEntity.Location> result = null;

            try
            {
                result = (from row in context.Locations
                          where row.ID == id
                          select row);
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex.Message, hosting);
            }

            return result.ToList();
        }
     

    }
}
