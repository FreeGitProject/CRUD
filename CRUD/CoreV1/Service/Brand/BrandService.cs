using CoreV1.Dapper;
using CoreV1.Models.Brand;
using CoreV1.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using CoreV1.Service.Common;
using CoreV1.Helpers;
using Newtonsoft.Json;
using CoreV1.Models.Common;

namespace CoreV1.Service.Brand
{
    public class BrandService : BaseService, IBrandService
    {
        private IDapperRepository _dapperRepository;
        public BrandService(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }

        public BoolResponse CreateBrand(BrandAddModel model, string langCulture)
        {
            //Identity.OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924");
            //Identity.DomainId = Identity.OrgId;
            //Identity.Email = Identity.Email;
            var email = "test";
            DynamicParameters dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(
                new
                {
                    @OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924"),
                    @DomainId = Guid.Parse("24C4AAB5-1B09-4C45-A7EA-C2CCE16E4D6D"),
                    @BrandName = model.ManufacturerName,
                    @LangCulture = langCulture,
                    @SavedBy = email,
                    @Type = model.Type,
                    @ParentBrandId = model.ParentManufId
                }
            );
            var dbResponse = _dapperRepository.Update<BoolResponse>(DBProcedures.ProcCreateBrand, dbParams, OmnicxConstants.DB_OMNICXMASTER);
            var prcResult = dbResponse;
            var blResp = new BoolResponse
            {
                IsValid = prcResult.IsValid,
                Message = prcResult.Message,
                RecordId = prcResult.RecordId,
            };
            return blResp;
        }

        public BrandModel GetBrand(Guid id, string langCulture)
        {
            DynamicParameters dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(
                new
                {
                    @OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924"),
                    @DomainId = Guid.Parse("24C4AAB5-1B09-4C45-A7EA-C2CCE16E4D6D"),
                    @ManufId = id,
                    @LangCulture = langCulture
                }
            );
            var dbResponse = _dapperRepository.GetAll<dynamic>(DBProcedures.ProcGetBrand, dbParams, OmnicxConstants.DB_OMNICXMASTER);

            var brand = (
                        from o in dbResponse
                        select new BrandModel
                        {
                            RecordId = o.ManufacturerId,
                            ManufacturerName = o.Name,
                            ExcludeFromSearch = o.ExcludeForSearch,
                            ShowSiteStrip = o.ShowSiteStrip,
                            VideoID = o.VideoUrl,
                            LogoImageName = o.LogoImageName,
                            PremiumBrandLogo = o.PremiumBrandLogo,
                            EnableMoreAbout = o.EnableMoreAbout,
                            SubbrandIds = o.SubbrandIds,
                            HideBrandVisibility = o.HideBrandVisibility,
                            HideSubbrandVisibility = o.HideSubbrandVisibility,
                            HideProductVisibility = o.HideProductVisibility,
                            ShowLandingPage = o.showLandingpage,
                            IsActive = o.IsActive,
                            CustomURL = o.CustomURL,
                            IsCustomUrl = o.IsCustomUrl,
                            DisplayTemplate = o.DisplayTemplate,
                            IsHighlighted = o.IsHighlighted,
                            WidgetsConfig = o.WidgetsConfig,
                            CssClass = o.CssClass
                        }).FirstOrDefault();

            return brand;
        }

        public List<ImageItem> GetBrandMedia(Guid recordId)
        {
            var mediaList = new List<ImageItem>();
            DynamicParameters dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(
                new
                {
                    @OrgId = Identity.OrgId,
                    @DomainId = Identity.DomainId,
                    @BrandId = recordId
                }
            );
            var dbResponse = _dapperRepository.GetAll<dynamic>(DBProcedures.ProcGetBrandMedia, dbParams, OmnicxConstants.DB_OMNICXMASTER);
            var response = dbResponse.FirstOrDefault();
            if (response?.JsonResult != null)
                mediaList = JsonConvert.DeserializeObject<List<ImageItem>>(response.JsonResult);
            return mediaList;
        }

        public List<BrandModel> GetBrands(int? currentPage, int? pageSize, BrandFilter filter, string langCulture)
        {
            DynamicParameters dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(
                new
                {
                    @OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924"),
                    @DomainId = Guid.Parse("24C4AAB5-1B09-4C45-A7EA-C2CCE16E4D6D"),
                    @ManufactureId = filter.ManufacturerId,
                    @Name = filter.Name,
                    @CurrentPage = currentPage,
                    @PageSize = pageSize,
                    @IsParentManuf = filter.IsParentManufId,
                    @IsActive = filter.IsActive,
                    @LangCulture = langCulture
                }
            );
            var dbResponse = _dapperRepository.GetAll<dynamic>(DBProcedures.ProcGetBrandList, dbParams, OmnicxConstants.DB_OMNICXMASTER);

            var brands = (
                        from o in dbResponse
                        select new BrandModel
                        {
                            RecordId = o.ID,
                            ManufacturerName = o.Name,
                            Created = o.Created,
                            CreatedBy = o.CreatedBy,
                            LastUpdated = o.LastUpdated,
                            LastUpdatedBy = o.LastUpdatedBy,
                            Description = o.Description,
                            CategoryCode = o.CategoryCode,
                            ChildCount = o.ChildCount,
                            CurrentPage = (int)currentPage,
                            PageSize = (int)pageSize,
                            TotalRecord = o.TotalRecord,
                            MetaDescription = o.MetaDescription,
                            MetaTitle = o.MetaTitle,
                            ParentManufId = Convert.ToString(o.ParentManufId),
                            ParentManufacturerName = o.ParentManufName,
                            Id = o.IId,
                            IsActive = (bool)o.IsActive,
                            ProductCount = o.ProductCount,
                            LogoImageName = o.LogoImageName,
                            PremiumBrandLogo = o.PremiumBrandLogo,
                            IsHighlighted = o.Ishighlighted ?? false,
                            CssClass = o.CssClass
                        }
                    ).ToList();

            return brands;
        }

        public List<LocalizedEntity> GetLocalizedEntities(Guid entityId, string langCulture = "", string className = "")
        {

            DynamicParameters dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(
                new
                {
                    @ClassName = className,
                    @LangCulture = langCulture,
                    @EntityId = entityId,
                    @OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924"),
                    @DomainId = Guid.Parse("24C4AAB5-1B09-4C45-A7EA-C2CCE16E4D6D"),
                }
            );
            var dbResponse = _dapperRepository.GetAll<dynamic>(DBProcedures.ProcGetLocalTextEntity, dbParams, OmnicxConstants.DB_OMNICXMASTER);

            var entityProperties = (from o in dbResponse
                                    select SetLocalTextProperty(new LocalizedEntity
                                    {
                                        ClassName = o.ClassName,
                                        EntityId = o.EntityId,
                                        DomainId = Identity.DomainId,
                                        LangCulture = o.LangCulture,
                                        SeoName = o.SeoName,
                                        Name = o.Name,
                                        Description = o.Description,
                                        ShortDescription = o.ShortDescription,
                                        Slug = o.Slug,
                                        Image1 = o.Image1,
                                        Image2 = o.Image2,
                                        Image3 = o.Image3,
                                        Image4 = o.Image4,
                                        Image5 = o.Image5,
                                        MetaTitle = o.MetaTitle,
                                        MetaDescription = o.MetaDescription,
                                        MetaKeywords = o.MetaKeywords,
                                        Canonical = o.Canonical,
                                        //Properties = o.Properties != null ? (from p in o.Properties.JsonToObjectList()
                                        //                                     select new LocalizedEntityProperty
                                        //                                     {
                                        //                                         Name = p.Key,
                                        //                                         Value = p.Value
                                        //                                     }).ToList() : new List<LocalizedEntityProperty>()
                                    }));
            return entityProperties.ToList();
        }

        public BoolResponse UpdateBrand(BrandSaveModel model, string langCulture)
        {
            var dbParams = new DynamicParameters();
            dbParams.AddDynamicParams(new
            {
                @OrgId = Guid.Parse("571B795F-BAA7-40AE-9EA9-76B1E23AC924"),
                @DomainId = Guid.Parse("24C4AAB5-1B09-4C45-A7EA-C2CCE16E4D6D"),
                @ManufId = model.RecordId,
                @Name = model.ManufacturerName,
                @ExcludeForSearch = model.ExcludeFromSearch,
                @ShowSiteStrip = model.ShowSiteStrip,
                @VideoId = model.VideoID,
                @LogoImageName = model.LogoImageName,
                @PremiumBrandLogo = model.PremiumBrandLogo,
                @LastUpdatedBy = model.LastUpdatedBy,
                @SubbrandIds = model.SubbrandIds,
                @EnableMoreAbout = model.EnableMoreAbout,
                @WidgetsConfig = model.WidgetsConfig,
                @HideBrandVisibility = model.HideBrandVisibility,
                @HideSubbrandVisibility = model.HideSubbrandVisibility,
                @HideProductVisibility = model.HideProductVisibility,
                @showLandingpage = model.ShowLandingPage,
                @IsCustomUrl = model.IsCustomUrl,
                @CustomURL = model.CustomURL,
                @isactive = model.IsActive,
                @DisplayTemplate = model.DisplayTemplate,
                @Ishighlighted = model.IsHighlighted,
                @CssClass = model.CssClass,
                @LangCulture = langCulture
            });
            var dbResponse = _dapperRepository.Update<BoolResponse>(DBProcedures.ProcUpdateBrand, dbParams, OmnicxConstants.DB_OMNICXMASTER);
            var prcResult = dbResponse;
            var blResp = new BoolResponse
            {
                IsValid = prcResult.IsValid,
            };
            return blResp;
        }

        private LocalizedEntity SetLocalTextProperty(LocalizedEntity entity)
        {
            if (entity == null) return entity;
            var properties = entity.Properties?.Where(x => !entity.GetType().GetProperties().Any(y => y.Name == x.Name)).ToList();
            properties = properties ?? new List<LocalizedEntityProperty>();

            properties.Insert(0, new LocalizedEntityProperty { Name = "Name", Value = entity.Name ?? "" });
            properties.Insert(1, new LocalizedEntityProperty { Name = "SeoName", Value = entity.SeoName ?? "" });
            properties.Insert(2, new LocalizedEntityProperty { Name = "Description", Value = entity.Description ?? "" });
            properties.Insert(3, new LocalizedEntityProperty { Name = "ShortDescription", Value = entity.ShortDescription ?? "" });
            properties.Insert(4, new LocalizedEntityProperty { Name = "Slug", Value = entity.Slug ?? "" });
            properties.Insert(5, new LocalizedEntityProperty { Name = "Image1", Value = entity.Image1 });
            properties.Insert(6, new LocalizedEntityProperty { Name = "Image2", Value = entity.Image2 ?? "" });
            properties.Insert(7, new LocalizedEntityProperty { Name = "Image3", Value = entity.Image3 ?? "" });
            properties.Insert(8, new LocalizedEntityProperty { Name = "Image4", Value = entity.Image4 ?? "" });
            properties.Insert(9, new LocalizedEntityProperty { Name = "Image5", Value = entity.Image5 ?? "" });
            properties.Insert(10, new LocalizedEntityProperty { Name = "MetaTitle", Value = entity.MetaTitle ?? "" });
            properties.Insert(11, new LocalizedEntityProperty { Name = "MetaDescription", Value = entity.MetaDescription ?? "" });
            properties.Insert(12, new LocalizedEntityProperty { Name = "MetaKeywords", Value = entity.MetaKeywords ?? "" });
            properties.Insert(13, new LocalizedEntityProperty { Name = "Canonical", Value = entity.Canonical ?? "" });
            entity.Properties = properties;
            return entity;
        }
        //public static IList<KeyValuePair<string, string>> JsonToObjectList(this string json)
        //{
        //    var jsonSerializerSettings = new JsonSerializerSettings
        //    {
        //        ContractResolver = new CamelCasePropertyNamesContractResolver()
        //    };
        //    json = json.Replace("''''", "\"");
        //    json = json.Replace("\"name\"", "\"key\"");
        //    try
        //    {
        //        var res = JsonConvert.DeserializeObject<IList<KeyValuePair<string, string>>>(json);
        //        return res == null ? new List<KeyValuePair<string, string>>() : res;
        //    }
        //    catch (Exception)
        //    {
        //        Need to make etry in dbo

        //    }
        //    return new List<KeyValuePair<string, string>>();
        //}
    }
}
