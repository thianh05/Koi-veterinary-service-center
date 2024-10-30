using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class BacsiController : BaseController<BacsiController>
    {
        public BacsiController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Bacsi>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.bacsiBLLRepo.GetListAllPaging(search, startIndex, pageSize);
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
            var model = new Bacsi();
            var data = _baseBLL.bacsiBLLRepo.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Bacsi model)
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
                var existsEmail = _baseBLL.bacsiBLLRepo.GetAll(model.Email.ToLower().Trim()).Where(x => x.Id != model.Id);
                if (existsEmail != null && existsEmail.Count() > 0)
                {
                    ViewBag.Error = $"Email {model.Email} đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    model.Availability = "Rảnh";
                    bool flag = _baseBLL.bacsiBLLRepo.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.bacsiBLLRepo.GetById(model.Id);
                    if(entity == null)
                    {
                        ViewBag.Error = "Thông tin bác sĩ không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TenBacSi = model.TenBacSi;
                    entity.Email = model.Email;
                    entity.KinhNghiem = model.KinhNghiem;
                    bool flag = _baseBLL.bacsiBLLRepo.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin bác sĩ không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Bacsi");
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
            var entity = _baseBLL.bacsiBLLRepo.GetById(id);
            if (entity != null)
            {
                _baseBLL.bacsiBLLRepo.Delete(id);
                return Redirect("/Admin/Bacsi");
            }
            return View();
        }
    }
}
