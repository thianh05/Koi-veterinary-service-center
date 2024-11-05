using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.Web.Areas.Admin.Controllers.Base;
using WebKoi6.Web.Areas.Admin.Models;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        public HomeController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(DateTime? date)
        {
            var model = new HomeReport();
            if (date == null)
            {
                date = DateTime.Now;
            }
            var data = _baseBLL.lichhenBLL.GetLichHenByDate(date.Value);
            model.TotalLichHen = data.Count();
            model.TotalLichChoXL = data.Where(x => x.Trangthai == 0).Count();
            model.TotalLichHenHoanthanh = data.Where(x => x.Trangthai == 2).Count();
            model.TotalLichHuy = data.Where(x => x.Trangthai == 3).Count();
            return View(model);
        }
    }
}