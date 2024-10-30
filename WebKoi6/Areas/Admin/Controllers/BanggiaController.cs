using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class BanggiaController : BaseController<BanggiaController>
    {
        public BanggiaController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(int dvid, int? page)
        {
            ViewBag.DichVu = _baseBLL.dichvuthuyBLL.GetAll();
            var model = new List<Banggia>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.banggiaBLL.GetListAllPaging(dvid, startIndex, pageSize);
            if (data != null && data.Count > 0)
            {
                total = data[0].TotalRows;
                model = data;
            }
            ViewBag.Search = dvid;
            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling((double)total / pageSize);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddOrEdit(int Id)
        {
            ViewBag.DichVu = _baseBLL.dichvuthuyBLL.GetAll();
            var model = new Banggia();
            var data = _baseBLL.banggiaBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Banggia model)
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
                ViewBag.DichVu = _baseBLL.dichvuthuyBLL.GetAll();
                if (model.MaDichVu == 0)
                {
                    ViewBag.Error = "Vui lòng chọn dịch vụ";
                    return View(model);
                }
                if (model.Gia <= 0)
                {
                    ViewBag.Error = "Vui lòng nhập giá trị giá tiền";
                    return View(model);
                }
                var existsDichvu = _baseBLL.banggiaBLL.GetBangGiaByDichVuId(model.MaDichVu, model.Id);
                if (existsDichvu != null)
                {
                    ViewBag.Error = $"Mã dịch vụ này đã tồn tại trong hệ thống";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    bool flag = _baseBLL.banggiaBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.banggiaBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin bảng giá không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.MaDichVu = model.MaDichVu;
                    entity.Gia = model.Gia;
                    bool flag = _baseBLL.banggiaBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Banggia");
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
            var entity = _baseBLL.banggiaBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.banggiaBLL.Delete(id);
                return Redirect("/Admin/Banggia");
            }
            return View();
        }
    }
}
