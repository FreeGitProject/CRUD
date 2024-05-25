using CoreV1.Models;
using CoreV1.Models.Brand;
using CoreV1.Models.Common;
using CoreV1.Service.Brand;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Newtonsoft.Json;
using System.Net;
using AutoMapper;
using CoreV1.Entities;

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
        private readonly IMapper _mapper;
        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _mapper = mapper;
            _brandService = brandService;
        }
    
        /// <summary>
        /// Create Brand
        /// </summary>
        /// <returns></returns> 
        [HttpPost]
        [Route("create")]
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
        /// <summary>
        /// Retrieves a paginated list of brands based on specified filters.
        /// </summary>
        /// <param name="currentPage">The current page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <param name="brandFilter">Filters to apply to the brand list.</param>
        /// <returns>A paginated response containing a list of brands.</returns>
        [HttpPost]
        [Route("")]
        public ResponseModelPaginated<List<BrandListModel>> Brands(int? currentPage, int? pageSize, BrandFilter brandFilter)
        {
            //_logger.LogInformation("Get brand list for langCulture :{@langCulture} and filter :{@brandFilter}", Identity.LangCulture, JsonConvert.SerializeObject(brandFilter));
            // Initialize response model
            var responseModel = new ResponseModelPaginated<List<BrandListModel>>();
            currentPage ??= currentPage > 0 ? currentPage : 1;
            pageSize ??= pageSize > 0 ? pageSize : 40;
            var brands = _brandService.GetBrands(currentPage, pageSize, brandFilter, "en-GB");
            var mappedBrands = _mapper.Map<List<BrandListModel>>(brands);
            //if (brands.Any())
            //{
            //    var orgSetting = _bulkImportService.GetOrgDetail(Identity.OrgId);
            //    var domain = orgSetting.Domains.FirstOrDefault(d => d.RecordId == Identity.DomainId);
            //    var imageUrl = domain.Settings.FirstOrDefault(s => s.Key.Equals("CatalogSettings.ImageUrl")).Value;
            //    var mappedBrands = _mapper.Map<List<BrandListModel>>(brands);
            //    mappedBrands.ForEach(brand =>
            //    {
            //        brand.LogoImageUrl = brand.LogoImageUrl.ImageUrl(ImageObjectTypes.Brand, string.Empty, imageBaseUrl: imageUrl);
            //        brand.PremiumLogoImageUrl = brand.PremiumLogoImageUrl.ImageUrl(ImageObjectTypes.Brand, string.Empty, imageBaseUrl: imageUrl);
            //    });
            //    // Brands exist, set Result and TotalRecords
            //    responseModel.Result = mappedBrands;
            //    responseModel.TotalRecords = brands.FirstOrDefault().TotalRecord;
            //}
            //else
            //{
            //    // No Brands found, set Result to an empty list and TotalRecords to 0
            //    responseModel.Result = new List<BrandListModel>();
            //    responseModel.TotalRecords = 0;
            //}
            // Brands exist, set Result and TotalRecords
            responseModel.Result = mappedBrands;
            responseModel.TotalRecords = brands.FirstOrDefault().TotalRecord;
            // Set other properties of responseModel
            responseModel.CurrentPage = currentPage;
            responseModel.PageSize = pageSize;
            responseModel.MessageCode = HttpStatusCode.OK.ToString();
            responseModel.StatusCode = HttpStatusCode.OK;
            responseModel.Status = HttpStatusCode.OK.ToString();

            return responseModel;
        }
        /// <summary>
		/// Get Brand by Id
		/// </summary>
		/// <returns></returns> 
		[HttpGet]
        [Route("{id}")]
        public ResponseModel<BrandModel> Get(Guid id)
        {
          //  _logger.LogInformation("Get brand for id : {@id} and langCulture : {@langCulture} ", id, Identity.LangCulture);
            //var orgSetting = _bulkImportService.GetOrgDetail(Identity.OrgId);
            //var domain = orgSetting.Domains.FirstOrDefault(d => d.RecordId == Identity.DomainId);
            //var imageUrl = domain.Settings.FirstOrDefault(s => s.Key.Equals("CatalogSettings.ImageUrl")).Value;

            var data = _brandService.GetBrand(id, "en-GB");
            var brand = _mapper.Map<BrandModel>(data);
            brand.ImageFiles = _brandService.GetBrandMedia(id);

            //brand.ImageFiles.ForEach(x => x.Link = x.Link.ImageUrl(ImageObjectTypes.Brand, string.Empty, imageBaseUrl: imageUrl));

            //brand.LocalizedPropertySet = _brandService.GetLocalizedEntities(id).Where(x => x.LangCulture == Identity.LangCulture).ToList();
            //brand.LogoImageUrl = brand.LogoImageUrl.ImageUrl(ImageObjectTypes.Brand, string.Empty, imageBaseUrl: imageUrl);
            //brand.PremiumLogoImageUrl = brand.PremiumLogoImageUrl.ImageUrl(ImageObjectTypes.Brand, string.Empty, imageBaseUrl: imageUrl);

            //brand.BrandDisplayTemplates = _masterDataService.GetMasetDataByTable(Identity.OrgId, Identity.DomainId, MasterTables.BrandDisplayTemplates);

            var responseModel = new ResponseModel<BrandModel>
            {
                Result = brand,
                MessageCode = HttpStatusCode.OK.ToString(),
                StatusCode = HttpStatusCode.OK,
                Status = HttpStatusCode.OK.ToString()
            };
            return responseModel;
        }
        /// <summary>
        /// Update Brand
        /// </summary>
        /// <returns></returns> 
        [HttpPut]
        [Route("")]
        public BoolResponse Update(BrandSaveModel model)
        {
           // _logger.LogInformation("Update brand request model : {@model} and langCulture : {@langCulture}", JsonConvert.SerializeObject(model), Identity.LangCulture);
            var resp = new BoolResponse();
            if (string.IsNullOrEmpty(Identity.UserName))
            {
                resp.MessageCode = HttpStatusCode.BadRequest.ToString();
                resp.Message = "UserName is missing in the header.";
                return resp;
            }
          //  var response = RuleHelper.ExecuteRules("ValidationData/Brand/create", model);
          //  if (!response.IsValid) return response;
            resp = _brandService.UpdateBrand(model, Identity.LangCulture);
            return resp;
        }
    }
}
