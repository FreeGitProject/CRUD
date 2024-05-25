using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    public class BrandListModel
    {
        public Guid RecordId { get; set; }
        public string ManufacturerName { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string Description { get; set; }
        public string CategoryCode { get; set; }
        public int? ChildCount { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string ParentManufId { get; set; }
        public string ParentManufacturerName { get; set; }
        public int? Id { get; set; }
        public bool? IsActive { get; set; }
        public int? ProductCount { get; set; }
        public string LogoImageUrl { get; set; }
        public string PremiumLogoImageUrl { get; set; }
        public bool? IsHighlighted { get; set; }
        public string CssClass { get; set; }
    }
}
