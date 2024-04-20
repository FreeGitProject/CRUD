using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Entities
{
    public enum ProductGroupTypes
    {
        None = 0,
        Brand = 1,
        Category = 2,
        Collection = 3
    }
    public enum ProductFieldGroup
    {
        None = 0,
        BasicInfo,
        Description,
        Media,
        SeoInfo,
        Category,
        Collections,
        Pricing,
        Identifiers,
        Dimensions,
        Shipping,
        GiftWrap,
        Brands,
        Purchasibilty,
        Domains
        //, RelatedProduct, GiftWrapConfig, Personalization
    }
    public enum CustomAttributeInputTypes
    {
        TextField = 1,
        Dropdown = 2,
        TextArea = 3,
        Date = 4,
        YesNo = 5,
        MultipleSelect = 6,
        ColorPicker = 8
    }
    public enum AcknowledgeType
    {
        Error = 0,
        Success = 1
    }
    public enum MediaType
    {
        Image,
        Video
    }

    public enum OrderProductsFieldGroup
    {
        //Order Tab Feilds
        None = 0,
        Products
    }

    public enum ShippingMethodTypes
    {
        None = 0,
        Standard = 1,
        Express = 2,
        Nominated = 3,
        Pickup = 4,
        //CollectPlus = 5,
        //Shutl = 6,
    }

    public enum GiftWrapSettings
    {
        None = 0,
        All = 1,
        Selected = 2
    }

    public enum GiftWrapTypes
    {
        None = 0,
        WholeOrder = 1,
        LineItems = 2
    }

    public enum PurchasabilityType
    {
        OnlineStore = 0,
        PreOrder,
        ForwardOrder
    }
    public enum BundleType
    {
        BOM = 0,
        Complementary = 1
    }
    public enum BundleDisplayType
    {
        Grouped = 0,
        Saperated = 1
    }
    public enum BundlePricetype
    {
        SumofAllProductPrice = 0,
        CustomPrice = 1
    }
    public enum RelatedProductAutoRuleTypes
    {
        SameSubBrand = 1,
        SameBrand = 2,
        SameRootCategory = 3,
        SameSubCategory = 4,
        SelectedSubBrand = 5,
        SelectedBrand = 6,
        SelectedRootCategory = 7,
        SelectedSubCategory = 8
    }

    public enum RelatedProductTypeCode
    {
        GWP = 1,
        UPGRADE = 2,
        ALSOLIKE = 3,
        ALSONEED = 4,
        BASKETGROUP = 5,
        ADDONS = 6
    }

    public enum RelatedProductAutoSortBy
    {
        PriceLowToHigh = 1,
        PriceHighToLow = 2,
        BestSellers = 9,
        ByReviews = 10
    }

    public enum ProductNature
    {
        NewProducts = 1,
        Incomplete = 2,
        Uncategorized = 3,
        Obsolete = 4
    }

    public enum InputTypes
    {
        Textbox = 1,
        Dropdown = 2,
        Checkbox = 3,
        Radiobutton = 4,
        Textarea = 5,
        File = 6,
        Editor = 7,
        ColorPicker = 8
    }
    public enum ValidationType
    {
        None = 0,
        SKU = 1
    }
    public enum Source
    {
        API = 1,
        WEBJOB = 2,
        APIGateway = 3
    }
    public enum ImportStage
    {
        Raw = 0,
        Staging = 1,
        Live = 2

    }
    public enum ImportStatus
    {
        Queued = 0,
        Processing = 1,
        Success = 2,
        Error = 3,
        PartiallyUpdated = 4,
        Scheduled = 5
    }
    public enum ImportDataType
    {
        Unknown = -1,
        Product = 0,
        Category = 1,
        Pricelist = 2,
        Inventory = 3,
        Related = 4,
        CustomAttribute = 5,
        Variants = 6,
        CustomAttributeMaster = 7,
        CustomAttributeOptionMaster = 8,
        CustomAttributeGroupSet = 10,
        ProductCollection = 11,
        ChannelUploadProduct = 12,
        ProductImage = 13,
        ProductVideo = 14,
        BulkOrderStatusUpdate = 15,
        ProductSerialNo = 16,
        CategoryProductMapping = 17,
        CategoryImage = 18,
        BrandImage = 19,
        ProductCustomAttributeSets = 20
    }
    public enum ProductChangeTypes
    {
        Created = 1,
        BasicInfo = 2,
        LanuchDate = 3,
        Status = 4,
        Pricelist = 5,
        Category = 6,
        Media = 7,
        Attribue = 8,
        RelatedProduct = 9,
        Bundle = 10,
        Tag = 11,
        AddVariant = 12,
        RemoveVariant = 13,
        Brand = 14,
        Collection = 15,
        Vendor = 16,
        HsnCode = 17,
        Coo = 18,
        BulkUpdateAnyField = 19,
        BulkUpdateMultipleFields = 20,
        Barcode = 21
    }

    public enum SearchType
    {
        All = 0,
        Category = 1,
        Brand = 2,
        Collection = 3,
        Season = 4,
        Status = 5,
        Tag = 6,
        Vendor = 7,
        Channel = 8,
        Advance = 9,
        Created = 10,
        Updated = 11,
        Workflow = 12,
        ParentProduct = 13,
        RichContent = 14,
        CategoryStats = 15,
        Types = 16
    }
    public enum StockAvailability
    {
        None = 0,
        InStock = 1,
        OutOfStock = 2,
        ClickNCollectOnly = 3,
        PreOrder = 4
    }
    /// <summary>
    /// 
    /// </summary>
    /// This should be same as  ItemTypesV3 from OmnicxEntities.Enums.Product.cs
    public enum ItemTypes
    {
        Product = 1,
        Service = 2,
        MembershipUpgrade = 20,  //as discussed to keep the changes simple new item type was introduced
        // RentalAsset = 3,
        GiftCard = 4,
        GiftBox = 189,
        GiftBoxLine = 202,
        //Variant = 6,
        //Virtual = 5,
        Bundle = 7,
        DynamicBundle = 8,
        Addon = 10

    }

    public enum MasterTables
    {
        Created = 2020,
        Updated = 2021,
        PIM_API_Root_Nodes = 2022,
        Country = 25,
        HSNCodes = 1800,
        Undefined = 0,
        ProductFamilies = 2100,
        PaymentTerm = 1101,
        ShipmentTerm = 1501,
        Currency = 16,
        UOM = 1900,
        RuleEngineFieldFilters = 2137,
        PriceOperand = 1035,
        ProductListOperand = 1034,
        BrandDisplayTemplates = 1104,
    }
    public enum BulkUpdateType
    {
        None = 0,
        MultipleFields = 1, /* Update multiple fields for multiple products*/
        AnyField = 2 /* update single field for multiple products */
    }
    public enum FieldUpdateType
    {
        Both = 0,
        Master = 1,
        Variant = 2,

    }
}
