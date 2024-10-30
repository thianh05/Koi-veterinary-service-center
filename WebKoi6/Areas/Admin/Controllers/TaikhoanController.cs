using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.BLL.Extensions;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class TaikhoanController : BaseController<TaikhoanController>
    {
        public TaikhoanController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search)
        {
            ViewBag.Search = search;    
            var data = _baseBLL.taiKhoanBLL.GetTaikhoans(search);
            return View(data);
        }
        [HttpGet]
        public IActionResult AddOrEdit(int id = 0)
        {
            var model = new Taikhoan();
            var data = _baseBLL.taiKhoanBLL.GeyById(id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Taikhoan model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.FullName) || string.IsNullOrEmpty(model.Username))
                {
                    ViewBag.Error = "Vui lòng họ tên và tài khoản";
                    return View(model);
                }
                if (string.IsNullOrEmpty(model.Password) && model.Id == 0)
                {
                    ViewBag.Error = "Vui lòng nhập mật khẩu";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    model.CreatedDate = DateTime.Now;
                    var hashPass = HashExtension.sha256(model.Password.Trim());
                    model.Password = hashPass;
                    bool flag = _baseBLL.taiKhoanBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới tài khoản không thành công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.taiKhoanBLL.GeyById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin tài khoản không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.FullName = model.FullName;
                    bool flag = _baseBLL.taiKhoanBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật tài khoản không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Taikhoan");
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
            var entity = _baseBLL.taiKhoanBLL.GeyById(id);
            if (entity != null)
            {
                _baseBLL.taiKhoanBLL.Delete(id);
                return Redirect("/Admin/Taikhoan");
            }
            return View();
        }
    }
}
