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
                var man = from m in dataContext.Manufacturers.Include("Ranges")
                          where m.ManufacturerName == manufacturerName
                          select m;

                result = MappingConfig.Map<ManufacturerModelRange>(man.FirstOrDefault());
            }
            return result;
        }
    }
}
