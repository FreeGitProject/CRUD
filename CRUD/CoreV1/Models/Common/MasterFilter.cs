using CoreV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Common
{
    public class MasterFilter : BaseEntity
    {
        //public int CurrentPage { get; set; }
        public string Name { get; set; }
        public int Match { get; set; }
        public Guid Category { get; set; }
        public string ItemGroup { get; set; }
        public string Manufacturer { get; set; }
        //public int PageSize { get; set; }
        public int ItemType { get; set; }
        public string StockCode { get; set; }
        public bool IsParentManufId { get; set; }
        public Guid? CustomSetId { get; set; }
        public bool IsVariant { get; set; }
        public bool IsActive { get; set; }
        public bool IsOutOfStock { get; set; }
        public int? Status { get; set; }
        public int? ActiveType { get; set; }
        public int? OutOfStockType { get; set; }
        public int InputType { get; set; }
        public int Localized { get; set; }
        public int UseInSearchFacet { get; set; }
        public int? EnableSubscription { get; set; }
        public ProductNature ProductNature { get; set; }
        public MasterFilter()
        {
            IsParentManufId = true;
        }
        public string LangCulture { get; set; }
        public Guid? ManufacturerId { get; set; }
    }
}
