using Range = Interview.Services.DataModels.Range;
using Moq;
using Interview.Services;
using Interview.Services.Infrastructure;
using System.Data.Entity;
using Interview.Services.DataModels;
using Interview.Services.Contracts;
using System;

namespace Interview.Tests.Infrastructure
{
    internal class Helper
    {
        private ManufacturerDataContext GetDataContext()
        {
            var mc = new Mock<ManufacturerDataContext>("constr");
            mc.Setup(r => r.Manufacturers).Returns(() => GetManufacturers());
            mc.Setup(r => r.Ranges).Returns(() => GetRanges());
            return mc.Object;
        }
        private DbSet<Manufacturer> GetManufacturers()
        {
            var dbs = new FakeDbSet<Manufacturer>();
            dbs.Add(new Manufacturer() { ManufacturerName = "Mercedes-Benz", Ranges = null, ManufacturerId = 1 });
            dbs.Add(new Manufacturer() { ManufacturerName = "Pagani", Ranges = null, ManufacturerId = 2 });
            return dbs;
        }
        private DbSet<Range> GetRanges()
        {
            var dbsRanges = new FakeDbSet<Range>();
            dbsRanges.Add(new Range() { ImageFile = "ImageFile1", ManufacturerId = 1, RangeId = 1, RangeName = "GLE" });
            dbsRanges.Add(new Range() { ImageFile = "ImageFile2", ManufacturerId = 1, RangeId = 2, RangeName = "GLE Coupe" });
            return dbsRanges;
        }

        internal static IModelRangeService GetInfrastructureService()
        {
            var con = new Mock<ConnectionInfo>("connectionstringstub");
            var mrs = new Mock<ModelRangeService>(con.Object);
            mrs.CallBase = true;
            mrs.Setup(r => r.GetDataContext()).Returns(() => Instance.GetDataContext());

            return mrs.Object;
        }

        private static readonly Lazy<Helper> lazy = new Lazy<Helper>(() => new Helper());

        public static Helper Instance { get { return lazy.Value; } }

        private Helper() { }
    }
}
