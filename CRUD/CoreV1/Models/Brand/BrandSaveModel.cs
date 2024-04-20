using CoreV1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    public class BrandSaveModel : BaseEntity
    {
        public string ManufacturerName { get; set; }
        public string LogoImageName { get; set; }
        public string PremiumBrandLogo { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public bool? ShowSiteStrip { get; set; }
        public bool? ShowLandingPage { get; set; }
        public string VideoID { get; set; }
        public bool? EnableMoreAbout { get; set; }
        public string WidgetsConfig { get; set; }
        public bool? HideBrandVisibility { get; set; }
        public bool? HideSubbrandVisibility { get; set; }
        public bool? HideProductVisibility { get; set; }
        public bool? IsCustomUrl { get; set; }
        public string CustomURL { get; set; }
        public bool? IsActive { get; set; }
        public string DisplayTemplate { get; set; }
        public bool? IsHighlighted { get; set; }
        public string CssClass { get; set; }
        public string SubbrandIds { get; set; }
        //public List<ImageItem> ImageFiles { get; set; }
        //  public List<LocalizedEntity> LocalizedPropertySet { get; set; }
    }

    //public class BrandSaveModel:BaseEntity
    //{
    //    public string ManufacturerName { get; set; }
    //    public string Slug { get; set; }
    //    public decimal PriceFrom { get; set; }
    //    public string Description { get; set; }
    //    public string ShortDescription { get; set; }
    //    public string ProductImage { get; set; }
    //    public string BgImageName { get; set; }
    //    public string LogoImageName { get; set; }
    //    public string PremiumBrandLogo { get; set; }
    //    public string CarouselImage1 { get; set; }
    //    public string CarouselImage2 { get; set; }
    //    public string CarouselImage3 { get; set; }
    //    public string CarouselImage4 { get; set; }
    //    public string CarouselImage5 { get; set; }
    //    public string CarouselImage6 { get; set; }
    //    public string CarouselLink1 { get; set; }
    //    public string CarouselLink2 { get; set; }
    //    public string CarouselLink3 { get; set; }
    //    public string CarouselLink4 { get; set; }
    //    public string CarouselLink5 { get; set; }
    //    public string CarouselLink6 { get; set; }
    //    public string WidgetLink1 { get; set; }
    //    public string WidgetLink2 { get; set; }
    //    public string WidgetLink3 { get; set; }
    //    public string WidgetLink4 { get; set; }
    //    public string WidgetImage1 { get; set; }
    //    public string WidgetImage2 { get; set; }
    //    public string WidgetImage3 { get; set; }
    //    public string WidgetImage4 { get; set; }
    //    public string Widget2Image { get; set; }
    //    public bool ExcludeFromSearch { get; set; }
    //    public bool ShowSiteStrip { get; set; }
    //    public bool ShowLandingPage { get; set; }
    //    public string BottomText { get; set; }
    //    public string VideoID { get; set; }
    //    public string AboutUsImage { get; set; }
    //    public string AboutUsDescription { get; set; }
    //    public string AboutUsLink { get; set; }
    //    public string CategoryCode { get; set; }
    //    public string ParentManufacturerName { get; set; }
    //    public string MetaTitle { get; set; }
    //    public string MetaDescription { get; set; }
    //    public string MetaKeywords { get; set; }
    //    public string Widget1Images { get; set; }
    //    public string Widget2Images { get; set; }
    //    public string Widget1ImagesLinks { get; set; }
    //    public string CarouselImages { get; set; }
    //    public string CarouselImagesLinks { get; set; }
    //    public string VideoUrl { get; set; }
    //    public int DisplayOrder { get; set; }
    //    public string ManImage { get; set; }
    //    public string WomanImage { get; set; }
    //    public string PrivateBrandImage { get; set; }
    //    public string ManLinkURI { get; set; }
    //    public string WomanLinkURI { get; set; }
    //    public string DescriptionForAllLister { get; set; }
    //    public string DescriptionForFemaleLister { get; set; }
    //    public string DescriptionForMaleLister { get; set; }
    //    public string IntroducingLogoImage { get; set; }
    //    public string IntroducingImage1 { get; set; }
    //    public string IntroducingImage2 { get; set; }
    //    public string IntroducingImage3 { get; set; }
    //    public string IntroducingLabel1 { get; set; }
    //    public string IntroducingLabel2 { get; set; }
    //    public string IntroducingLabel3 { get; set; }
    //    public string IntroducingDescription1 { get; set; }
    //    public string IntroducingDescription2 { get; set; }
    //    public string IntroducingDescription3 { get; set; }
    //    public bool EnableMoreAbout { get; set; }
    //    public string MoreAboutLink1Title { get; set; }
    //    public string MoreAboutLink1 { get; set; }
    //    public string MoreAboutLink2Title { get; set; }
    //    public string MoreAboutLink2 { get; set; }
    //    public string MoreAboutLink3Title { get; set; }
    //    public string MoreAboutLink3 { get; set; }
    //    public string MetaTitleForFemale { get; set; }
    //    public string MetaTitleForMale { get; set; }
    //    public string MetaDescriptionForFemale { get; set; }
    //    public string MetaDescriptionForMale { get; set; }
    //    public string MetaTitleForAll { get; set; }
    //    public string MetaDescriptionForAll { get; set; }
    //    public bool InStock { get; set; }
    //    public bool IsDelisted { get; set; }
    //    public string MicroSiteNames { get; set; }
    //    public string MicroSiteIds { get; set; }
    //    public string SubbrandIds { get; set; }
    //    public bool HideProductVisibility { get; set; }
    //    public bool HideBrandVisibility { get; set; }
    //    public bool HideSubbrandVisibility { get; set; }
    //    public bool IsFeatured { get; set; }
    //    public bool IsActive { get; set; }
    //    public bool IsCustomUrl { get; set; }
    //    public string CustomURL { get; set; }
    //    public string CanonicalTags { get; set; }
    //    public string Link { get; set; }
    //    public string DisplayTemplate { get; set; }
    //    public string ParentManufSlug { get; set; }
    //    public string ParentLogoImageName { get; set; }
    //    public int Level { get; set; }
    //    public string Image1 { get; set; }
    //    public string Image2 { get; set; }
    //    public string Image3 { get; set; }
    //    public string Image4 { get; set; }
    //    public string Image5 { get; set; }
    //  //  public List<BrandMediaFileItem> Files { get; set; }
    //    public bool IsHighlighted { get; set; }
    //    public string WidgetBannerImageUrl { get; set; }
    //    public string WidgetsConfig { get; set; }
    //    public string CssClass { get; set; }
    //}
}
