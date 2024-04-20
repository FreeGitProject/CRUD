using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    /// <summary>
    /// Represents a LocalizedEntity - mapping against the LocaltextEntity DB 
    /// </summary>
    [Serializable]
    public class LocalizedEntity
    {
        private List<LocalizedEntityProperty> _properties;
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public Guid EntityId { get; set; }
        public Guid DomainId { get; set; }
        /// <summary>
        /// Gets or sets the language identifier
        /// </summary>
        public string LangCulture { get; set; }
        /// <summary>
        /// Gets or sets the language identifier
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the Entity Class name
        /// </summary>
        public string ClassName { get; set; }
        public string StockCode { get; set; }

        public string SeoName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Slug { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string BlogSummary { get; set; }
        public string MetaKeywords { get; set; }
        public string Canonical { get; set; }

        /// <summary>
        /// Collection of localized properties based on lang culture
        /// </summary>
        public List<LocalizedEntityProperty> Properties
        {
            //if its null, create a new List & return
            get { return _properties ?? (_properties = new List<LocalizedEntityProperty>()); }
            set { _properties = value; }
        }
    }
    /// <summary>
    /// Represents a localized property
    /// </summary>
    [Serializable]
    public partial class LocalizedEntityProperty //: BaseEntity
    {

        //public long Id { get; set; }
        /// <summary>
        /// Gets or sets the locale key
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the locale value
        /// </summary>
        public string Value { get; set; }

    }
}
