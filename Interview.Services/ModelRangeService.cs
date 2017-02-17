using System.Linq;
using Interview.Services.Models;
using Interview.Services.Contracts;
using Interview.Services.Infrastructure;
using Interview.Services.Mapping;

namespace Interview.Services
{
    public class ModelRangeService : IModelRangeService
    {
        private readonly ConnectionInfo connectionInfo;
        public ModelRangeService(ConnectionInfo conInfo)
        {
            connectionInfo = conInfo;
        }

        public virtual ManufacturerDataContext GetDataContext() { return new ManufacturerDataContext(connectionInfo.ConnectionString); } 
        public ManufacturerModelRange GetManufacturerModelRange(string manufacturerName)
        {
            ManufacturerModelRange result;
            using (var dataContext = GetDataContext())
            {
                var man = from m in dataContext.Manufacturers
                        where m.ManufacturerName == manufacturerName
                        select m;

                var manuf = man.FirstOrDefault();

                if (manuf != null)
                {
                    var rng = from r in dataContext.Ranges
                              where r.ManufacturerId == manuf.ManufacturerId
                              select r;

                    manuf.Ranges = rng.ToList();
                }
                result = MappingConfig.Map<ManufacturerModelRange>(manuf);
            }
            return result;
        }
    }
}
