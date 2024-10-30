using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using WebKoi6.BLL;
using WebKoi6.Web.Areas.Admin.Models;

namespace WebKoi6.Web.Areas.Admin.Controllers.Base
{
    [Area("Admin")]
    public class BaseController<T> : Controller where T : BaseController<T>
    {
        protected IBaseBLL _baseBLL;
        protected IHttpContextAccessor _contextAccessor;
        protected IConfiguration _configuration { get; }
        public BaseController(IBaseBLL @baseBLL, IHttpContextAccessor contextAccessor, IConfiguration configuration)
        {
            _baseBLL = @baseBLL;
            _configuration = configuration;
            _contextAccessor = contextAccessor;
        }
        protected AdminSession GetUser()
        {
            try
            {
                var userSession = _contextAccessor.HttpContext.Session.GetString("Admin");
                if (userSession != null)
                {
                    return JsonConvert.DeserializeObject<AdminSession>(userSession);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        protected void SetUser(AdminSession data)
        {
            _contextAccessor.HttpContext.Session.SetString("Admin", JsonConvert.SerializeObject(data));
        }
        protected void ClearUser()
        {
            _contextAccessor.HttpContext.Session.Remove("Admin");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.ActionDescriptor.RouteValues["Controller"].ToLower() != "login")
            {
                if (GetUser() != null)
                {
                    base.OnActionExecuted(context);
                }
                else
                {
                    context.Result = new RedirectResult("/Admin/Login/Index");
                }
            }
            else
            {
                base.OnActionExecuted(context);
            }
        }
    }
}
