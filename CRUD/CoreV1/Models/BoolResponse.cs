using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models
{
    public class BoolResponse
    {
        // public AcknowledgeType Acknowledge { get; set; } = AcknowledgeType.Success;
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public string MessageCode { get; set; }
        public Guid RecordId { get; set; }
        public string RequestId { get; set; }
    }
}
