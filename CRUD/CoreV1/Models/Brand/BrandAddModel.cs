using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Brand
{
    public class BrandAddModel
    {
        public string ManufacturerName { get; set; }
        public Guid? ParentManufId { get; set; }
        public int Type { get; set; }
    }
}
