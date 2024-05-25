using CoreV1.Entities.brands;
using CoreV1.Models.Brand;
using CoreV1.Models.Common;
using AutoMapper;

namespace CRUD.ProfileMapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            //reverse so that both direction will work
            //  CreateMap<ProductListItem, ProductListItemModel>().ReverseMap();

            //CreateMap<TaxonomyItemModel, ChannelDomainMapping>().ReverseMap()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString() + "~" + ChannelTypes.Channel))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => ChannelTypes.Channel))
            //    .ForMember(dest => dest.Items, opt => opt.Ignore())
            //    .ForMember(dest => dest.IId, opt => opt.MapFrom(src => 0));

            ////workflows
            //CreateMap<Lifecycle, LifecycleAddModel>().ReverseMap();
            //CreateMap<Lifecycle, LifecycleModel>().ReverseMap();
            //CreateMap<LifecycleStep, LifecycleStepModel>().ReverseMap();
            //CreateMap<LifecycleStep, LifecycleStepAddModel>().ReverseMap();
            //CreateMap<Lifecycle, LifecycleGridLineModel>()
            //        .ForMember(dest => dest.NoOfSteps, opt => opt.MapFrom(src => src.Steps.Count))
            //        .ForMember(dest => dest.NoOfEntities, opt => opt.MapFrom(src => src.AppliesTo.Count));
            ////.ForMember(dest => dest.AppliedToDocumentType, opt => opt.MapFrom(src => src.DocumentType.ToString()));

            //CreateMap<LifecycleStep, LifecycleStepDetailModel>()
            //      .ForMember(dest => dest.Sections, opt => opt.Ignore())
            //      .ForMember(dest => dest.ToStatus, opt => opt.Ignore())
            //      .ForMember(dest => dest.LifecycleId, opt => opt.Ignore());

            //CreateMap<PimTask, TaskAddModel>().ReverseMap();

            //CreateMap<ProductLifecycleChangeLog, ProductLifecycleChangeLogModel>().ReverseMap();

            //CreateMap<TaxonomyItemModel, Lifecycle>().ReverseMap()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Steps))
            //    .ForMember(dest => dest.IId, opt => opt.MapFrom(src => 0));

            //CreateMap<TaxonomyItemModel, LifecycleStep>().ReverseMap()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => ((src.ParentStatusId > 0) ? "--" : "-") + src.Name))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StatusId))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Items, opt => opt.Ignore())
            //    .ForMember(dest => dest.IId, opt => opt.MapFrom(src => 0));

            //CreateMap<MasterData, ProductFamilyModel>().ReverseMap()
            //   .ForMember(dest => dest.ItemText, opt => opt.MapFrom(src => src.Name))
            //   .ForMember(dest => dest.ItemValue, opt => opt.MapFrom(src => src.Code))
            //   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            //CreateMap<RuleEngineEntityMapping, RuleEngineEntityMappingModel>().ReverseMap();
            //CreateMap<RuleEngineRuleSet, RuleEngineRuleSetModel>().ReverseMap()
            //    .ForMember(dest => dest.WorkflowsToInject, opt => opt.MapFrom(src => src.WorkflowsToInject))
            //    ;

            //CreateMap<RuleEngine, RuleEngineModel>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId))
            //    .ForMember(dest => dest.WorkflowsToInject, opt => opt.MapFrom(src => src.WorkflowsToInject))
            //    .ForPath(dest => dest.RuleSet, opt => opt.MapFrom(src => src.RuleSet))
            //    .ForPath(dest => dest.EntityMapping, opt => opt.MapFrom(src => src.EntityMapping))
            //;

            //CreateMap<RuleEngineSaveModel, RuleEngine>()
            //    .ForMember(dest => dest.RecordId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.Id, opt => opt.Ignore())
            //    .ForMember(dest => dest.WorkflowsToInject, opt => opt.MapFrom(src => src.WorkflowsToInject))
            //    .ForMember(dest => dest.LastUpdatedBy, opt => opt.MapFrom(src => src.SavedBy))
            //    .ForPath(dest => dest.RuleSet, opt => opt.MapFrom(src => src.RuleSet))
            //    .ForPath(dest => dest.EntityMapping, opt => opt.MapFrom(src => src.EntityMapping))
            //;

            //CreateMap<RuleEngine, RuleEngineList>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId))
            //    .ForMember(dest => dest.WorkflowsToInject, opt => opt.MapFrom(src => src.WorkflowsToInject))
            //    ;

            //CreateMap<ProductFamilyAddModel, MasterData>()
            //.ForMember(dest => dest.ItemText, opt => opt.MapFrom(src => src.Name))
            //.ForMember(dest => dest.ItemValue, opt => opt.MapFrom(src => src.Code));

            //CreateMap<PimTask, TaskModel>()
            // .ForMember(dest => dest.Id, opt => opt.MapFrom(src => new Guid(src.Id.ToString())));

            //CreateMap<CreateSupplierModel, Supplier>()
            //.ForMember(dest => dest.Type, opt => opt.MapFrom(src => (SupplierTypes)src.Type));

            //CreateMap<UpdateSupplierModel, Supplier>()
            //.ForMember(dest => dest.Type, opt => opt.MapFrom(src => (SupplierTypes)src.Type))
            //.ForMember(dest => dest.POCreateType, opt => opt.MapFrom(src => (SupplierPOCreateTypes)src.POCreateType));

            //CreateMap<TaxonomyItemModel, CategoryListModel>()
            //    .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.Items));

            //CreateMap<TaxonomyItemModel, BrandListModel>();

            //CreateMap<CommentsAddModel, TaskNote>()
            //  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //  .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
            //  .ForMember(dest => dest.Created, opt => opt.Ignore())
            //  .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
            //  .ForMember(dest => dest.LastUpdated, opt => opt.Ignore())
            //  .ForMember(dest => dest.LastUpdatedBy, opt => opt.Ignore());

            //CreateMap<NotificationUpdateModel, Notification>();

            //CreateMap<Notification, NotificationModel>()
            //     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()));

            //CreateMap<AddProductQuantityBreakRuleModel, AddProductQuantityBreakRule>();

            //CreateMap<AddQuantityBreakRuleModel, AddQuantityBreakRule>()
            //      .ForMember(dest => dest.PricingMechanism, opt => opt.MapFrom(src => ((PricingMechanismType)Enum.Parse(typeof(PricingMechanismType), src.PricingMechanism, true)).GetHashCode()))
            //      .ForMember(dest => dest.PricingMechanismLabel, opt => opt.MapFrom(src => src.PricingMechanism))
            //    ;

            //CreateMap<ProductQuantityBreakRuleModel, ProductQuantityBreakRule>().ReverseMap();
            //CreateMap<QuantityBreakRuleModel, QuantityBreakRule>().ReverseMap()
            //     .ForMember(dest => dest.PricingMechanism, opt => opt.MapFrom(src => src.PricingMechanismLabel))
            //   ;
            //CreateMap<RuleEngineRuleSet, RuleEngineModels.Rule>()
            //    .ForMember(dest => dest.RuleName, opt => opt.MapFrom(src => src.RuleName))
            //     .ForMember(dest => dest.Properties, opt => opt.Ignore())
            //     .ForMember(dest => dest.Operator, opt => opt.Ignore())
            //     .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.ErrorMessage))
            //     .ForMember(dest => dest.Enabled, opt => opt.MapFrom(src => src.Enabled))
            //     .ForMember(dest => dest.RuleExpressionType, opt => opt.Ignore())
            //     .ForMember(dest => dest.WorkflowsToInject, opt => opt.Ignore())
            //     .ForMember(dest => dest.Rules, opt => opt.Ignore())
            //     .ForMember(dest => dest.LocalParams, opt => opt.Ignore())
            //     .ForMember(dest => dest.Expression, opt => opt.MapFrom(src => src.Expression))
            //     .ForMember(dest => dest.Actions, opt => opt.Ignore())
            //     .ForMember(dest => dest.SuccessEvent, opt => opt.MapFrom(src => src.SuccessEvent))
            //    ;
            //CreateMap<RuleEngine, RuleEngineModels.Workflow>()
            //     .ForMember(dest => dest.WorkflowName, opt => opt.MapFrom(src => src.RuleEngineName))
            //     .ForMember(dest => dest.WorkflowsToInject, opt => opt.Ignore())
            //     .ForMember(dest => dest.GlobalParams, opt => opt.Ignore())
            //     .ForMember(dest => dest.Rules, opt => opt.MapFrom(src => src.RuleSet))
            //   ;
            //CreateMap<CustomAttributeSet, CustomAttributeSetModel>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId.ToString()));
            //CreateMap<CategoryEntity, CategoryModel>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId.ToString()))
            //    .ForMember(dest => dest.Iid, opt => opt.MapFrom(src => src.Id.ToString()));
            //CreateMap<CategoryListEntity, CategoryListModel>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId.ToString()))
            //    .ForMember(dest => dest.IId, opt => opt.MapFrom(src => src.Id.ToString()));
            //CreateMap<Core.Entities.Pricelists.Pricelist, PricelistModel>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            //    .ForMember(dest => dest.CurrencyCode, opt => opt.MapFrom(src => src.CurrencyCode))
            //    .ForMember(dest => dest.IsDefault, opt => opt.MapFrom(src => src.IsDefault))
            //    .ForMember(dest => dest.IsGlobal, opt => opt.MapFrom(src => src.IsGlobal))
            //    .ForMember(dest => dest.SellPrice, opt => opt.MapFrom(src => src.SellPrice))
            //    .ForMember(dest => dest.ListPrice, opt => opt.MapFrom(src => src.ListPrice))
            //    .ForMember(dest => dest.SellPriceExclusiveVat, opt => opt.MapFrom(src => src.SellPriceExclusiveVat))
            //    .ForMember(dest => dest.MinPrice, opt => opt.MapFrom(src => src.MinPrice))
            //    .ForMember(dest => dest.MinPriceWithoutTax, opt => opt.MapFrom(src => src.MinPriceWithoutTax))
            //    .ForMember(dest => dest.MaxPrice, opt => opt.MapFrom(src => src.MaxPrice))
            //    .ForMember(dest => dest.MaxPriceWithoutTax, opt => opt.MapFrom(src => src.MaxPriceWithoutTax))
            //    .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            //    .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            //    .ForMember(dest => dest.CostPrice, opt => opt.MapFrom(src => src.CostPrice))
            //    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
            //    .ForMember(dest => dest.IsPricelistDynamic, opt => opt.MapFrom(src => src.IsPricelistDynamic))
            //    .ForMember(dest => dest.SourcePricelistId, opt => opt.MapFrom(src => src.SourcePricelistId))
            //    .ForMember(dest => dest.SourcePricelistName, opt => opt.MapFrom(src => src.SourcePricelistName))
            //    .ForMember(dest => dest.SourcePricelistCurrencyCode, opt => opt.MapFrom(src => src.SourcePricelistCurrencyCode))
            //    .ForMember(dest => dest.IsBufferPct, opt => opt.MapFrom(src => src.IsBufferPct))
            //    .ForMember(dest => dest.BufferValue, opt => opt.MapFrom(src => src.BufferValue))
            //    .ForMember(dest => dest.Roundup, opt => opt.MapFrom(src => src.Roundup))
            //    .ForMember(dest => dest.ConversionRate, opt => opt.MapFrom(src => src.ConversionRate))
            //    .ForMember(dest => dest.IsConversionRateDynamic, opt => opt.MapFrom(src => src.IsConversionRateDynamic))
            //    .ForMember(dest => dest.ConversionRateLastUpdated, opt => opt.MapFrom(src => src.ConversionRateLastUpdated))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId))
            //    ;

            //CreateMap<Core.Entities.Pricelists.PricelistDetail, PricelistDetailModel>()
            //  .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            //  .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName))
            //  .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            //  .ForMember(dest => dest.CurrencyCode, opt => opt.MapFrom(src => src.CurrencyCode))
            //  .ForMember(dest => dest.CostPrice, opt => opt.MapFrom(src => src.CostPrice))
            //  .ForMember(dest => dest.SellPrice, opt => opt.MapFrom(src => src.SellPrice))
            //  .ForMember(dest => dest.ListPrice, opt => opt.MapFrom(src => src.ListPrice))
            //  .ForMember(dest => dest.SellPriceExclusiveVat, opt => opt.MapFrom(src => src.SellPriceExclusiveVat))
            //  .ForMember(dest => dest.Worth, opt => opt.MapFrom(src => src.Worth))
            //  .ForMember(dest => dest.PriceEffectiveDate, opt => opt.MapFrom(src => src.PriceEffectiveDate))
            //  .ForMember(dest => dest.ListPriceExclusiveVat, opt => opt.MapFrom(src => src.ListPriceExclusiveVat))
            //  .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //  .ForMember(dest => dest.PricelistId, opt => opt.MapFrom(src => src.RecordId.ToString()))
            //  ;
            //// Mapping from MasterData to Currency
            //CreateMap<MasterData, Currency>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CustomField1))
            //    .ForMember(dest => dest.CurrencyCode, opt => opt.MapFrom(src => src.ItemText))
            //    .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.CustomField2))
            //    .ForMember(dest => dest.CurrencySymbolIsPrefix, opt => opt.MapFrom(src => src.CustomField3))
            //    .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.Displayorder))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId))
            //    .ForMember(dest => dest.Published, opt => opt.MapFrom(src => src.isActive));

            //// Reverse mapping from Currency to MasterData
            //CreateMap<Currency, MasterData>()
            //    .ForMember(dest => dest.CustomField1, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.ItemText, opt => opt.MapFrom(src => src.CurrencyCode))
            //    .ForMember(dest => dest.CustomField2, opt => opt.MapFrom(src => src.CurrencySymbol))
            //    .ForMember(dest => dest.CustomField3, opt => opt.MapFrom(src => src.CurrencySymbolIsPrefix.ToString()))
            //    .ForMember(dest => dest.Displayorder, opt => opt.MapFrom(src => src.DisplayOrder))
            //    .ForMember(dest => dest.RecordId, opt => opt.MapFrom(src => src.Id));

            //CreateMap<AccountManagerModel, UserBasicInfo>();

            //CreateMap<UserBasicInfo, AccountManagerModel>();

            //CreateMap<Supplier, SupplierListModel>()
            // .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId));
            //CreateMap<Supplier, SupplierModel>()
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RecordId));

            //CreateMap<Core.Entities.Products.Product, ProductListModel>();

            CreateMap<Brand, BrandListModel>();
            CreateMap<Brand, BrandModel>();
            //CreateMap<UpdateCategoryIsFeaturedModel, UpdateCategoryIsFeatured>();
            //CreateMap<BrandCategoryMappingEntity, BrandCategoryMapping>();
            //CreateMap<StagingDataItem, StagingDataItemModel>();
            //CreateMap<ProductStagingListData, ProductStagingListDataModel>();

        }
    }
}
