using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class CauhoiController : BaseController<CauhoiController>
    {
        public CauhoiController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Faq>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.cauhoiBLL.GetListAllPaging(search, startIndex, pageSize);
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
        [HttpGet]
        public IActionResult AddOrEdit(int Id)
        {
            var model = new Faq();
            var data = _baseBLL.cauhoiBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Faq model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).FirstOrDefault();
                    if (error != null)
                    {
                        ViewBag.Error = error;
                        return View(model);
                    }
                    else
                    {
                        ViewBag.Error = "Vui lòng nhập đầy đủ thông tin";
                        return View(model);
                    }
                }
                var existsEmail = _baseBLL.cauhoiBLL.GetAll(model.CauHoi.ToLower().Trim()).Where(x => x.Faqid != model.Faqid);
                if (existsEmail != null && existsEmail.Count() > 0)
                {
                    ViewBag.Error = $"Câu hỏi {model.CauHoi} đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.Faqid == 0)
                {
                    bool flag = _baseBLL.cauhoiBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.cauhoiBLL.GetById(model.Faqid);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin câu hỏi không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.CauHoi = model.CauHoi;
                    entity.CauTraLoi = model.CauTraLoi;
                    bool flag = _baseBLL.cauhoiBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin câu hỏi không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Cauhoi");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = _baseBLL.cauhoiBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.cauhoiBLL.Delete(id);
                return Redirect("/Admin/Cauhoi");
            }
            return View();
        }
    }
}
