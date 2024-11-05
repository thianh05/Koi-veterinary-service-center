using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class TrungtamController : BaseController<TrungtamController>
    {
        public TrungtamController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Trungtam>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.trungtamBLL.GetListAllPaging(search, startIndex, pageSize);
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
            var model = new Trungtam();
            var data = _baseBLL.trungtamBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Trungtam model)
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
                var existsEmail = _baseBLL.trungtamBLL.GetAll(model.TenTrungTam.ToLower().Trim()).Where(x => x.Id != model.Id);
                if (existsEmail != null && existsEmail.Count() > 0)
                {
                    ViewBag.Error = $"Tên trung tâm {model.TenTrungTam} đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    bool flag = _baseBLL.trungtamBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.trungtamBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin trung tâm không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TenTrungTam = model.TenTrungTam;
                    entity.DiaChi = model.DiaChi;
                    entity.Hotline = model.Hotline;
                    entity.MoTa = model.MoTa;
                    bool flag = _baseBLL.trungtamBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin trung tâm không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Trungtam");
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
            var entity = _baseBLL.trungtamBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.trungtamBLL.Delete(id);
                return Redirect("/Admin/Trungtam");
            }
            return View();
        }
    }
}
