using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    public class BrandFilter
    {
        public string? Name { get; set; }
        public bool? IsParentManufId { get; set; }
        public bool? IsActive { get; set; }
        public Guid? ManufacturerId { get; set; }
    }
}
