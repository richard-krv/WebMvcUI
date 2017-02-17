using Interview.ModelMapping;
using Interview.Models;
using Interview.Services.Contracts;
using System.Web.Mvc;

namespace Interview.Controllers
{
    [HandleError]
    public class RangeController : Controller
    {
        private IModelRangeService modelRangeService;
        public RangeController(IModelRangeService modelRangeService)
        {
            this.modelRangeService = modelRangeService;
            AutoMapper.Mapper.Initialize(config => config.AddProfile<ManufacturerRangeServiceToViewMappingProfile>());
        }
        // GET /Range/List?name=manufacturer
        public ActionResult List(string name)
        {
            return View(GetManufacturer(name));
        }
        public ActionResult ListStriptUrl(string id)
        {
            if (id == "Home" || string.IsNullOrEmpty(id)) return RedirectToAction("Index", "Home");
            return View("List", GetManufacturer(id));
        }

        protected ManufacturerViewModel GetManufacturer(string name)
        {
            var modelRange = modelRangeService.GetManufacturerModelRange(name);
            
            var model = MappingConfig.Map<ManufacturerViewModel>(modelRange);
            model = HandleInvalidModel(model, name);
            return model;
        }

        protected ManufacturerViewModel HandleInvalidModel(ManufacturerViewModel model, string queryName)
        {
            if (model == null)
                model = new Models.ManufacturerViewModel() { Name = queryName };
            return model;
        }
    }
}