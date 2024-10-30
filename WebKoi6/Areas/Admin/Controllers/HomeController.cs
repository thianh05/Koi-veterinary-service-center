using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        public HomeController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}