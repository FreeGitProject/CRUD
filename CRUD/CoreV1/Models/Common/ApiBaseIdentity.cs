using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Models.Common
{
    public class ApiBaseIdentity : IIdentity
    {
        public string Name { get; set; }

        public Guid DomainId { get; set; }

        public Guid OrgId { get; set; }

        public Guid AppId { get; set; }

        public string UserId { get; set; }

        public string AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string IpAddress { get; set; }

        public string SessionId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Initials
        {
            get
            {
                string empty = string.Empty;
                empty = ((!string.IsNullOrEmpty(FirstName)) ? FirstName.Substring(0, 1) : "");
                empty += ((!string.IsNullOrEmpty(LastName)) ? LastName.Substring(0, 1) : "");
                if (string.IsNullOrEmpty(empty))
                {
                    object obj = UserName ?? Email;
                    if (obj == null)
                    {
                        obj = "Hi";
                    }

                    empty = ((string?)obj + "Hi").Substring(0, 2);
                }

                return empty;
            }
        }

        public Guid BranchId { get; set; }

        public string CompanyId { get; set; }

        public string LangCulture { get; set; }

        public string CurrencyCode { get; set; }

        public string Country { get; set; }

        public string Channel { get; set; }

        public string BrowserInfo { get; set; }

        public string Coo { get; set; }

        public string UrlReferrer { get; set; }

        public string ReferralType { get; set; }

        public string DeviceId { get; set; }

        public string IsGhostLogin { get; set; }

        public string AdminUserName { get; set; }

        public Guid MicrositeId { get; set; }

        public string OrgCode { get; set; }

        public string OrgName { get; set; }
    }
}
