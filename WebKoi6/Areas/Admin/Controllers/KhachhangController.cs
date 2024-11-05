using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class KhachhangController : BaseController<KhachhangController>
    {
        public KhachhangController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Khachhang>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.khachhangBLL.GetListAllPaging(search, startIndex, pageSize);
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
            var model = new Khachhang();
            var data = _baseBLL.khachhangBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Khachhang model)
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
                var existsEmail = _baseBLL.khachhangBLL.CheckExistsKhachhang(model.Email, model.Id);
                if (existsEmail != null)
                {
                    ViewBag.Error = $"Email {model.Email} đã tồn tại trong hệ thống";
                    return View(model);
                }
                var existsSDT = _baseBLL.khachhangBLL.CheckExistsKhachhang(model.SoDienThoai, model.Id);
                if (existsSDT != null)
                {
                    ViewBag.Error = $"Số điện thoại {model.SoDienThoai} đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    bool flag = _baseBLL.khachhangBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.khachhangBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin khách hàng không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TenKhachHang = model.TenKhachHang;
                    entity.Email = model.Email;
                    entity.SoDienThoai = model.SoDienThoai;
                    bool flag = _baseBLL.khachhangBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin khách hàng không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Khachhang");
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
            var entity = _baseBLL.khachhangBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.khachhangBLL.Delete(id);
                return Redirect("/Admin/Khachhang");
            }
            return View();
        }
    }
}
