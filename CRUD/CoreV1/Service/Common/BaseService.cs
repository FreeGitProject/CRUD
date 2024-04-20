using CoreV1.Models.Common;
using Newtonsoft.Json;

namespace CoreV1.Service.Common
{
    public class BaseService
    {
        private ApiBaseIdentity _identity;
        public ApiBaseIdentity Identity
        {
            get

            {
                // only typecast if the current identity is not of type WindowsIdentity.
                if (_identity == null && Thread.CurrentPrincipal.Identity != null && Thread.CurrentPrincipal.Identity.GetType() != typeof(System.Security.Principal.WindowsIdentity))
                    _identity = (ApiBaseIdentity)Thread.CurrentPrincipal.Identity;
                return _identity;
            }
        }
        protected JsonSerializerSettings JsonSettings
        {
            get
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                return settings;
            }
        }
    }
}
