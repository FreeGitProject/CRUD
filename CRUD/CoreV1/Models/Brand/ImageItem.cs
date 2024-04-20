using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    [Serializable]
    public class ImageItem
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        /// <summary>
        /// Relative path of the image file excluding the container & blob path (banners/image.jpg)
        /// </summary>
        public string Image { get; set; }
        public ImageObjectTypes? ImageTypes { get; set; }
        /// <summary>
        /// Full SRC of the image including the blob path, (https://blob.azure.com/ocx/conatiner/banners/image.jpg)
        /// </summary>
        public string Url { get; set; }
        public string MobileUrl { get; set; }
        public string Id { get; set; }
        public string Alt { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string LinkType { get; set; }
        public string ButtonText { get; set; }
        public string EventCategory { get; set; }
        public string EventAction { get; set; }
        public string GaValue { get; set; }
        public bool IsActive { get; set; }
        public string CssClass { get; set; }
        public string Segment { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public byte[] Data { get; set; }
        //  public List<ImageTag> ImageTags { get; set; }
        public MediaTypes MediaType { get; set; }
        public Guid EntityId { get; set; }
    }
    public enum ImageObjectTypes
    {
        None = 0,
        Product = 1,
        Brand = 2,
        SubBrand = 3,
        Promos = 4,
        Widgets = 7,
        Blog = 6,
        Content = 5,
        Category = 8

    }
    public enum MediaTypes
    {
        Image = 0,
        Video = 1,
        Pdf = 2,

    }
}
