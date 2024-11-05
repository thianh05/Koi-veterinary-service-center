using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class DichvuthuyController : BaseController<DichvuthuyController>
    {
        public DichvuthuyController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Dichvuthuy>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.dichvuthuyBLL.GetDichvuthuyListAll(search, startIndex, pageSize);
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
            var model = new Dichvuthuy();
            var data = _baseBLL.dichvuthuyBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Dichvuthuy model)
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
                var existsDichVu = _baseBLL.dichvuthuyBLL.CheckExistsDichVu(model.TenDichVu, model.MaDichVu);
                if (existsDichVu != null)
                {
                    ViewBag.Error = $"Dịch vụ {model.TenDichVu} đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.MaDichVu == 0)
                {
                    bool flag = _baseBLL.dichvuthuyBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.dichvuthuyBLL.GetById(model.MaDichVu);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin dịch vụ không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TenDichVu = model.TenDichVu;
                    entity.MoTa = model.MoTa;
                    bool flag = _baseBLL.dichvuthuyBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin dịch vụ không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Dichvuthuy");
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
            var entity = _baseBLL.dichvuthuyBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.dichvuthuyBLL.Delete(id);
                return Redirect("/Admin/Dichvuthuy");
            }
            return View();
        }
    }
}
