using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Common
{
    /// <summary>
    /// Base class for Business Objects
    /// </summary>
    [Serializable]
    public abstract partial class BaseEntity
    {

        private int _currentPage;
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the GUID based entity identifier
        /// </summary>
        public Guid RecordId { get; set; }

        /// <summary>
        /// Local text key for the entity
        /// </summary>
        public string LocalTextKey { get; set; }

        /// <summary>
        /// Gets or sets the Created Date time
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the LastUpdated Date time
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the Created by
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the LastUpdated By
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Get or Set IpAddress
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the GUID based Org Identifier
        /// </summary>
        public Guid OrgId { get; set; }


        /// <summary>
        /// Gets or sets the GUID based Branch Identifier
        /// </summary>
        public Guid BranchId { get; set; }


        /// <summary>
        /// Gets or sets the GUID based Domain Identifier
        /// </summary>
        public Guid DomainId { get; set; }

        public int TotalRecord { get; set; }

        public int CurrentPage
        {
            get
            {
                if (_currentPage == 0)
                {
                    return 1;
                }
                return _currentPage;
            }
            set
            {
                _currentPage = value;
            }
        }
        public int PageSize { get; set; }
    }
}
