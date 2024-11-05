using Newtonsoft.Json;
using WebKoi6.Web.Areas.Admin.Models;

namespace WebKoi6.Web.Areas.Admin.Helpers
{
    public static class Sessions
    {
        public static AdminSession GetUser(IHttpContextAccessor _httpContextAccessor)
        {
            var userSession = _httpContextAccessor.HttpContext.Session.GetString("Admin");
            if (userSession != null)
            {
                return JsonConvert.DeserializeObject<AdminSession>(userSession);
            }
            return null;
        }
    }
}
