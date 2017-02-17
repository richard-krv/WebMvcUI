using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.Controllers;
using Interview.Services.Contracts;
using Interview.Services;
using Moq;
using Interview.Services.Infrastructure;
using System.Collections.Generic;
using System.Collections;
using Interview.Tests.Infrastructure;
using Range = Interview.Services.DataModels.Range;
using Interview.Services.DataModels;
using System.Data.Entity;
using System.Web.Mvc;
using Interview.Models;
using System.Linq;

namespace Interview.Tests.Controllers
{
    [TestClass]
    public class RangeControllerTest
    {
        private IModelRangeService GetService()
        {
            return Helper.GetInfrastructureService();
        }

        [TestMethod]
        public void TestRangeController_Action_List()
        {
            var ctr = new RangeController(GetService());

            object manuf = null;
            try
            {
                var res = ctr.List("Mercedes-Benz") as ViewResult;
                manuf = res.ViewData.Model;
            }catch(Exception ex)
            {
                Assert.Fail("The Range controller has failed with message {0}", ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsInstanceOfType(manuf, typeof(ManufacturerViewModel), "Range controller supplying view with a model of incorrect type");
            var manufacturer = manuf as ManufacturerViewModel;
            if (manufacturer == null) return;
            Assert.AreEqual("Mercedes-Benz", manufacturer.Name);
            Assert.AreEqual(2, manufacturer.RangeItems.Count());
            Assert.AreEqual(1, manufacturer.RangeItems.Where(ri => ri.Name == "GLE").Count());
            Assert.AreEqual(1, manufacturer.RangeItems.Where(ri => ri.Name == "GLE Coupe").Count());
        }

        [TestMethod]
        public void TestRangeController_Action_ListStriptUrl()
        {
            var ctr = new RangeController(GetService());

            object manuf = null;
            try
            {
                var res = ctr.ListStriptUrl("Pagani") as ViewResult;
                manuf = res.ViewData.Model;
            }
            catch (Exception ex)
            {
                Assert.Fail("The Range controller has failed with message {0}", ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsInstanceOfType(manuf, typeof(ManufacturerViewModel), "Range controller supplying view with a model of incorrect type");
            var manufacturer = manuf as ManufacturerViewModel;
            if (manufacturer == null) return;
            Assert.AreEqual("Pagani", manufacturer.Name);
            Assert.AreEqual(0, manufacturer.RangeItems.Count());
        }

        [TestMethod]
        public void TestRangeController_Action_ListStriptUrl_NonExistingMake()
        {
            var ctr = new RangeController(GetService());

            object viewModel = null;
            try
            {
                var res = ctr.ListStriptUrl("Hispano-Suiza") as ViewResult;
                viewModel = res.ViewData.Model;
            }
            catch (Exception ex)
            {
                Assert.Fail("The Range controller has failed with message {0}", ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsNull(viewModel);
        }

        [TestMethod]
        public void TestRangeController_Action_ListStriptUrl_InvalidInput()
        {
            var ctr = new RangeController(GetService());

            object viewModel = null;
            try
            {
                var res = ctr.ListStriptUrl("injectingcode{select 1 from table}") as ViewResult;
                viewModel = res.ViewData.Model;
            }
            catch (Exception ex)
            {
                Assert.Fail("The Range controller has failed with message {0}", ex.Message, ex.StackTrace);
                return;
            }
            Assert.IsNull(viewModel);
        }
    }
}
