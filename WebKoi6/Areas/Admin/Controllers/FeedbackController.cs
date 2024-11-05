using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class FeedbackController : BaseController<FeedbackController>
    {
        public FeedbackController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Feedback>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.feebackBLL.GetFeedbackListAllPaging(search, startIndex, pageSize);
            if (data != null && data.Count > 0)
            {
                total = data[0].TotalRows;
                model = data;
            }
            if (string.IsNullOrEmpty(search))
            {
                search = string.Empty;
            }
            ViewBag.Search = search;
            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling((double)total / pageSize);
            return View(model);
        }
    }
}
