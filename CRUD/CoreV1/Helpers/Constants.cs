using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Helpers
{
    public static class DBProcedures
    {
        #region Product Procedure Constants
        public const string ProcGetAllPriceList = "procGetAllPriceList_20201130";
        public const string ProcJsonGetProductDetail = "procJsonGetProductDetail_20231016";
        public const string procJsonGetProductDetailbyStockCode = "procJsonGetProductDetailbyStockCode_20240305";
        public const string ProcJsonUpsertProduct = "procJsonUpsertProduct_20231124";
        public const string ProcJsonGetProductCustomAttributes_SurveyJS = "procJsonGetProductCustomAttributes_SurveyJS_20200810";
        public static string ProcJsonGetProductFormMasterData = "procJsonGetProductFormMasterData_20200703";
        public static string ProcJsonGetProductFormMasterData_All = "procJsonGetProductFormMasterData_All_20191129";
        public static string ProcJsonGetProductFieldInfoGroupWise = "procJsonGetProductFieldInfoGroupWise_20201026";
        public static string ProcDeleteProductImage = "procDeleteProductImage_20210824";
        public static string ProcJsonUpsertBundleProduct = "procJsonUpsertBundleProduct";
        public static string ProcJsonUpdatevariantProductInfo = "procJsonUpdatevariantProductInfo_20220425";
        public static string ProcJsonUpdateVariantProductLaunchDate = "procJsonUpdateVariantProductLaunchDate_20230620";
        public static string ProcJsonUpdateProductStatus = "procJsonUpdateProductStatus_20211014";

        public static string ProcJsonUpdateProductPricing = "procJsonUpdateProductPricing_20210903";


        public const string ProcJsonUpsertProductBasicinfo = "procJsonUpdateProductBasicInfo_20230628";
        public const string ProcJsonUpsertProductCategory = "procJsonUpdateProductCategory_20231006";
        public const string ProcJsonUpdateProductMedia = "procJsonUpdateProductMedia_20230628";
        public const string ProcJsonUpdateProductBrand = "procJsonUpdateProductBrand_20230630";
        public const string ProcJsonUpdateProductAttribute = "procJsonUpdateProductAttribute_20230628";
        public const string ProcJsonUpdateProductRelatedInfo = "procJsonUpsertRelatedProduct_20230629";
        //public const string ProcJsonUpdateProductBundle = "procJsonUpdateProductBundle_20230109";
        public const string ProcJsonUpdateProductTags = "procSaveTagProductMapping_20230629";
        public const string ProcJsonAddProductVariant = "procJsonAddProductVariant_20230109";
        public const string ProcJsonRemoveProductVariant = "procDeleteProductVariation_20220211";

        public const string ProcBulkUpdateProduct = "procBulkUpdateProduct_20230721";
        public const string ProcBulkUpdateProductTags = "procBulkUpdateProductTagMapping_20230720";
        public const string ProctProductMetaField = "procGetProductMetaField_20230602";

        public const string ProcInsertRawBulkUpdateRequest = "procInsertRawBulkUpdateRequest_20231123";
        public const string ProcRemoveAttributeBulkUpdateRequest = "procRemoveAttributeBulkUpdateRequest_20240111";
        public const string ProcBulkUpdateAnyField = "procBulkUpdateAnyField_20231123";
        public const string ProcJsonGetProductFieldsData = "procJsonGetProductFieldsData_20240228";

        public const string ProcAddProductQuantityBreakRule = "procAddProductQuantityBreakRule_20231201";
        public const string ProcJsonGetProductQuantityBreakRule = "procJsonGetProductQuantityBreakRule_20231128";
        public const string ProcUpdateProductFulfillmentFlags = "procUpdateProductFulfilmentFlags_20231218";

        public const string ProcUpsertLocalTextField = "procUpsertLocalTextField_20240213";
        public const string ProcGetLocalTextField = "procGetLocalTextField_20240213";

        #endregion

        #region Product staging data
        public const string ProcSaveBulkProductStagingData = "procSaveBulkProductStagingData_20230907";
        public const string ProcSaveBulkUpdateAnyFieldStagingData = "procSaveBulkUpdateAnyFieldStagingData_20231005";
        public const string ProcSaveBulkUpdateMultipleFieldStagingData = "procSaveBulkUpdateMultipleFieldStagingData_20231005";
        public const string ProcGetProductStagingDataList = "procGetProductStagingDataList_20231120";
        public const string ProcUpdateProductStagingDataStatus = "procUpdateProductStagingDataStatus_20240110";
        public const string ProcGetProductStagingData = "procGetProductStagingData_20240110";
        #endregion

        #region Bulk Import Procedure Constants
        public const string procBulkUploadProductAttribute = "procImportRawCustomAttributeData_20230530";
        public const string procImportBulkPriceList = "procImportBulkPriceList_20240223";
        public const string procUpsertRequestProcessExeption = "procUpsertRequestProcessExeption";
        public const string procUpsertImportRequest = "procUpsertImportRequest_20240228";
        public const string procBulkProductImport = "procImportRawData_20240228";
        public const string procBulkUploadAttributeMaster = "procBulkUploadAttributeMaster_20240304";
        public const string procBulkUploadAttributeOptionsMaster = "procBulkUploadAttributeOptionsMaster_20231114";
        public const string procBulkImportCustomFieldSetGroupFieldCode = "procBulkImportCustomFieldSetGroupFieldCode_20231101";
        public const string procGetOrgDetail = "procGetOrgDetail_20210201";
        public const string procImportRelatedProduct = "procImportRelatedProduct_20240226";
        public const string procImportRawInventory = "procImportRawInventory_20190726";
        public const string procImportCategoryData = "procImportCategoryData_20231016";
        public const string procGetWarehouseByCode = "procGetWarehouseByCode_20220221";
        public const string procSaveProductCollectionDisplayOrder = "procSaveProductCollectionDisplayOrder_20231121";
        public const string procImportProductImage = "procImportRawProductImage_20231220";
        public const string procImportCategoryImage = "procBulkImportCategoryImage_20231016";
        public const string procImportBrandImage = "procBulkImportBrandImage_20231016";
        public const string procImportProductVideo = "procBulkImportProductVideo_20231016";
        public const string procImportProductSerialNo = "procBulkImportProductSerialNo_20231016";
        public const string procImportCategoryProductMapping = "procBulkImportCategoryProductMapping_20240109";
        public const string procImportProductCustomAttributeSets = "procBulkImportProductCustomAttributeSets_20231026";
        public const string procBulkUploadVariants = "procImportVariantsRawData_20240304";



        #endregion

        #region Log Procedure Constants
        public const string ProcJsonUpsertVariantProductActivityLog = "procJsonUpsertVariantProductActivityLog";
        public const string ProcJsonUpsertProductActivityLog = "procJsonUpsertProductActivityLog";
        public const string ProcJsonUpsertProductStatusChangeLog = "procJsonUpsertProductStatusChangeLog_20210219";
        public const string ProcSaveProductChangeLog = "procSaveProductChangeLog";
        public const string procSaveProductLifeCycle = "procSaveProductLifeCycle_20231009";
        public const string procGetProductLifecycleChangeLog = "procGetProductLifecycleChangeLog_20231018";
        public const string ProcJsonUpsertProductBarcode = "procJsonUpsertProductBarcode_20231102";
        #endregion

        #region Taxonomy Procedure Constants
        public const string ProcGetAllCategories = "procJsonGetCategories_20230626";
        public const string ProcGetAllBrands = "procGetMasterManufacturers_20230721";
        public const string ProcGetAllCollectionsXML = "procXMLSiteGetListDataset_Adm_20210811";
        public const string ProcGetAllSeasons = "procGetAllSeasons";
        public const string ProcGetAllTags = "procGetAllTags";
        public const string ProcGetAllVendors = "procGetAllVendors";
        public const string ProcPeriodFilterDetails = "procGetPeriodFilters";
        public const string ProcGetRootNodes = "procGetPIMAPIRootNodes_20230726";
        public const string ProcGetAllDomains = "procGetAllDomains";
        public const string ProcGetMasterDataList = "procGetMasterDataList";
        public const string ProcSaveMasterData = "procSaveMasterData";
        public const string ProcGetBrandBasicInfo = "procJsonGetBrandBasicInfo_20230619";
        public const string ProcGetCategoryBasicInfo = "procJsonGetCategoryBasicInfo_20231106";
        #endregion

        #region Brand
        public const string ProcCreateBrand = "procAddBrand_20240311";
        public const string ProcGetBrandList = "procGetMasterManufacturers_20240522";//"procGetMasterManufacturers_20240311";
        public const string ProcGetBrand = "procGetManufacturerContent_20240312";//"procGetManufacturerContent_20240312";
        public const string ProcGetBrandMedia = "procGetBrandMedia_20230628";
        public const string ProcGetLocalTextEntity = "procGetLocalTextEntity_20210904";
        public const string ProcUpdateBrand = "procSaveManufacturerContent_20240521";
        #endregion
        #region Search Procedure Constants
        public const string ProcGetAllProductsByEntityId = "procCatalogSearchObject_20240228";
        public const string ProcSearchProducts = "procCatalogSearchObjectAdvance_20240228";
        public const string ProcCatalogSearchByEntity = "procCatalogSearchByEntity_20231110";
        public const string CollectionAPI_URL = "/api/v2/catalog/search/advanced/minimal"; // "/api/v2/catalog/collection/id/" + Id;
        public const string SaveCollectionFilterAPI_URL = "/api/v2/catalog/collection/filter";
        #endregion

        #region Master Data Procedure Constants
        public const string ProcJsonGetMasterData = "procJsonGetMasterData_20230523";
        public const string ProcJsonGetHSNCodeData = "procJsonGetHSNCodeData_20230525";
        #endregion

        #region Product lifecycle Procedure Constants
        public const string ProcGetproductLifecycleDashboard = "procGetproductLifecycleDashboard_20230712";
        #endregion

        #region RuleEngine Procedure Constants
        public const string ProcJsonGetRuleEngines = "procJsonGetRuleEngines_20230613";
        public const string ProcJsonGetRuleEngineDetail = "procJsonGetRuleEngineDetail_20231222";
        public const string ProcJsonUpsertRuleEngine = "procJsonUpsertRuleEngine_20230816";

        public const string ProcGetRuleFields = "procGetRuleFields_20240402";
        public const string ProcGetRuleFieldOptions = "procGetRuleFiledFilterOption_20240402";

        public const string ProcGetRules = "procGetRules_20240322";
        public const string ProcGetRuleById = "procGetRuleById_20240322";
        public const string ProcJsonSaveRule = "procJsonSaveRule_20240402";
        public const string ProcDeleteRule = "procDeleteRule_20240318";




        #endregion

        #region Supplier Procedure Constants
        public const string ProcSaveSupplier = "procSaveSupplier_20230707";
        public const string ProcUpdateSupplier = "procUpdateSupplierDetail_20230707";
        #endregion

        #region User and Role Procedure Constants
        public const string ProcGetAdminUsersByOrgDomain = "procGetAdminUsersByOrgDomain_20231018";
        public const string ProcGetUserRoleGroup = "procGetUserRoleGroup_20210728";
        public const string ProcGetMultipleRoleGroupPermissions = "procGetMultipleRoleGroupPermissions_20230620";
        public const string procGetUsersByRole = "procGetUsersByRole_20210722";
        #endregion



    }

    public static class CacheKeys
    {
        public const string USER_DOMAINS = "{0}.USER.DOMAINS";

        public const string MASTERDATA = "MASTERDATA.{0}.{1}";//0-ORGID, 1-TABLEID

        public const string RULE_FIELDS = "RULE.FIELDS.{0}.{1}";

        public const string RULE_FIELD_OPTIONS = "RULE.FIELD.OPTIONS.{0}.{1}.{2}"; //0-OrgId,1-DomainId,2-FieldType
    }


    public static class Constants
    {
        #region MongoDB Details
        public const string MongoDBConnectionString = "MongoDBConnectionString";
        public const string ChannelMasterDatabaseName = "ChannelMasterDatabaseName";
        public const string ChannelDomainDatabasePrefix = "ChannelDomainDatabasePrefix";
        public const string PIM_Channel_ProductMapping = "PIM_Channel_ProductMapping";
        public const string ChannelMappingCollectionname = "ChannelMappingCollectionname";


        //public const string ProcSearchProducts = "procCatalogSearchObjectAdvance_20230302";
        //public const string CollectionAPI_URL = "/api/v2/catalog/search/advanced/minimal"; // "/api/v2/catalog/collection/id/" + Id;
        #endregion

        #region API end point
        public const string BulkAnyFieldAPI = "bulk-update/any-field";
        public const string BulkBrandAPI = "bulk-update/brand";
        public const string BulkCOOAPI = "bulk-update/coo";
        public const string BulkHsnCodeAPI = "bulk-update/hsn-code";
        public const string BulkMultiFieldAPI = "bulk-update/multiple-fields";
        public const string BulkRemoveAttributeAPI = "bulk-update/remove-attribute-fields";
        public const string BulkTagAPI = "bulk-update/tags";
        public const string BulkVendorAPI = "bulk-update/vendor";
        public const string BulkStatusAPI = "bulk-update/status";
        public const string BulkCollectionAPI = "bulk-update/collection";
        #endregion

        #region RuleEngine
        public const string PIMAPIUpsertProduct = "PIMAPI Upsert product";
        #endregion

        #region ValidationData
        public const string ProductCreateUpdateValidation = "ValidationData/Product/create-update";
        public const string ProductLaunchDateValidation = "ValidationData/Product/launchdate";
        public const string ProductStatusValidation = "ValidationData/Product/status";
        public const string ProductPricingValidation = "ValidationData/Product/pricing";
        public const string ProductBasicInfoValidation = "ValidationData/Product/basic-info";
        public const string ProductCategoryUpdateValidation = "ValidationData/Product/category-update";
        public const string ProductMediaUpdateValidation = "ValidationData/Product/media-update";
        public const string ProductBrandValidation = "ValidationData/Product/brand";
        public const string ProductAttributesValidation = "ValidationData/Product/attributes";
        public const string ProductRelatedProductValidation = "ValidationData/Product/relatedproduct";
        public const string ProductTagsValidation = "ValidationData/Product/tags";
        public const string ProductVariantValidation = "ValidationData/Product/variant";
        public const string ProductRemoveVariantValidation = "ValidationData/Product/remove-variant";
        public const string BrandCreateUpdateValidation = "ValidationData/Brand/create";

        #endregion
    }

    public static class CRUDActions
    {
        public const string Create = "create";
        public const string Update = "update";
        public const string Delete = "delete";

    }

    public static class ChannelTypes
    {
        public const string Domain = "domain";
        public const string Channel = "channel";
    }

    public static class LocalTextEntityType
    {
        public const string CustomAttribute = "CustomAttribute";
    }
    public class OmnicxConstants
    {
        public const string DB_OMNICXMASTER = "MasterDataConnectionString";
        public const string DB_OMNICXAUDIT = "AuditLogDataConnectionString";
        public const string DB_OMNICXSTAGING = "StagingV2DataConnectionString";
        public const string DB_OMNICXCONTENT = "ContentDataConnectionString";
    }
}
