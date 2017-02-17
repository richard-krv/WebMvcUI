using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Interview.Services;
using Interview.Services.Infrastructure;
using System;
using Interview.Services.Models;
using System.Linq;

namespace Interview.Tests.Infrastructure
{
    [TestClass]
    public class DataRetrievalTest
    {
        [TestMethod]
        public void ManufacturerService_RetrievingAMake()
        {
            var mrs = Helper.GetInfrastructureService();

            object manuf = null;
            try
            {
                manuf = mrs.GetManufacturerModelRange("Mercedes-Benz");
            }
            catch (Exception ex)
            {
                Assert.Fail("The infrastructure service has failed retrieving data with message {0}"
                    , ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsInstanceOfType(manuf, typeof(ManufacturerModelRange), "Service returning data of incorrect type");
            var manufacturer = manuf as ManufacturerModelRange;
            if (manufacturer == null) return;
            Assert.AreEqual("Mercedes-Benz", manufacturer.Name);
            Assert.AreEqual(2, manufacturer.ModelRangeItems.Count());
            Assert.AreEqual(1, manufacturer.ModelRangeItems.Where(ri => ri.Name == "GLE").Count());
            Assert.AreEqual(1, manufacturer.ModelRangeItems.Where(ri => ri.Name == "GLE Coupe").Count());
        }

        [TestMethod]
        public void ManufacturerService_RetrievingAMake_wo_Range()
        {
            var mrs = Helper.GetInfrastructureService();


            object manuf = null;
            try
            {
                manuf = mrs.GetManufacturerModelRange("Pagani");
            }
            catch (Exception ex)
            {
                Assert.Fail("The infrastructure service has failed retrieving data with message {0}"
                    , ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsInstanceOfType(manuf, typeof(ManufacturerModelRange), "Service returning data of incorrect type");
            var manufacturer = manuf as ManufacturerModelRange;
            if (manufacturer == null) return;
            Assert.AreEqual("Pagani", manufacturer.Name);
            Assert.AreEqual(0, manufacturer.ModelRangeItems.Count());
        }

        [TestMethod]
        public void ManufacturerService_Retrieving_nonexisting_Make()
        {
            var mrs = Helper.GetInfrastructureService();

            object manuf = null;
            try
            {
                manuf = mrs.GetManufacturerModelRange("Cord");
            }
            catch (Exception ex)
            {
                Assert.Fail("The infrastructure service has failed retrieving data with message {0}"
                    , ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsNull(manuf);
        }


    }
}
