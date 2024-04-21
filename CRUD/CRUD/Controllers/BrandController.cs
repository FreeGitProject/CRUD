using CoreV1.Models;
using CoreV1.Models.Brand;
using CoreV1.Models.Common;
using CoreV1.Service.Brand;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace CRUD.Controllers
{
    //[ApiVersion("1")]
    //[Route("api/v{v:apiVersion}/brand")]
    //[ApiController]
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        protected ApiBaseIdentity Identity => (ApiBaseIdentity)Thread.CurrentPrincipal.Identity;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
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
