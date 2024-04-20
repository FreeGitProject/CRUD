using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Common
{
    public class MasterData : BaseEntity
    {
        public int TableId { get; set; }
        public string ItemText { get; set; }
        public string ItemValue { get; set; }
        public int Displayorder { get; set; }
        public bool isActive { get; set; }
        public bool IsGlobalForOrg { get; set; }
        public bool IsDefault { get; set; }
        public string ParentItemValue { get; set; }
        public string Flag { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string LocalTextKey { get; set; }

    }
}
