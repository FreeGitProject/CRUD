using CoreV1.Models;
using CoreV1.Models.Brand;
using CoreV1.Models.Common;
using CoreV1.Service.Brand;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualBasic;
using System.Security.Principal;

namespace CRUD.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        protected ApiBaseIdentity Identity => (ApiBaseIdentity)Thread.CurrentPrincipal.Identity;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Create Brand
        /// </summary>
        /// <returns></returns> 
        [HttpPost]
        [Route("")]
        public BoolResponse Create(BrandAddModel model, string langCulture)
        {
           // _logger.LogInformation("Create brand request model : {@model} and langCulture : {@langCulture}", model, langCulture);
            if (string.IsNullOrEmpty(langCulture))
                langCulture = Identity.LangCulture;
          //  var response = RuleHelper.ExecuteRules(Constants.BrandCreateUpdateValidation, model);
            //if (!response.IsValid) return response;
            var resp = _brandService.CreateBrand(model, langCulture);
            return resp;
        }
    }
}
