using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;
using WebKoi6.Web.Areas.Admin.Models;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class LichhenController : BaseController<LichhenController>
    {
        public LichhenController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<LichhenMapping>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.lichhenBLL.GetListAllPaging(search, startIndex, pageSize);
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
        public void ViewDefault()
        {
            ViewBag.ListBacsi = _baseBLL.bacsiBLLRepo.GetAll();
            ViewBag.ListDichvu = _baseBLL.dichvuthuyBLL.GetAll();
            ViewBag.Khachhang = _baseBLL.khachhangBLL.GetAll();
        }
        [HttpGet]
        public IActionResult AddOrEdit(int Id)
        {
            ViewDefault();
            var model = new Lichhen();
            var data = _baseBLL.lichhenBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Lichhen model)
        {
            ViewDefault();
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
                if (model.DichVuId == 0 || model.KhachhangId == 0 || model.DichVuId == 0 || model.Ngayhen == null)
                {
                    ViewBag.Error = "Vui lòng nhập đầy đủ thông tin";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    bool flag = _baseBLL.lichhenBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.lichhenBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin lịch hẹn không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.BacsiId = model.BacsiId;
                    entity.KhachhangId = model.KhachhangId;
                    entity.DichVuId = model.DichVuId;
                    entity.Ngayhen = model.Ngayhen;
                    bool flag = _baseBLL.lichhenBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin lịch hẹn không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Lichhen");
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
            var entity = _baseBLL.lichhenBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.bacsiBLLRepo.Delete(id);
                return Redirect("/Admin/Lichhen");
            }
            return View();
        }
        [HttpGet]
        public IActionResult ChangeStatus(int Id)
        {
            var model = new Lichhen();
            var data = _baseBLL.lichhenBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult ChangeStatus(Lichhen model)
        {
            try
            {
                var entity = _baseBLL.lichhenBLL.GetById(model.Id);
                if (entity == null)
                {
                    ViewBag.Error = "Thông tin lịch hẹn không tồn tại trong hệ thống";
                    return View(model);
                }
                var objBacsi = _baseBLL.bacsiBLLRepo.GetById(entity.BacsiId);
                if (objBacsi == null)
                {
                    ViewBag.Error = "Thông tin bác sĩ không tồn tại trong hệ thống";
                    return View(model);
                }            
                if(model.Trangthai == 2 || model.Trangthai == 3)
                {             
                    objBacsi.Availability = "Rảnh";
                }
                else if(model.Trangthai == 1)
                {
                    objBacsi.Availability = "Bận";
                }
                entity.Trangthai = model.Trangthai;
                bool flagBS = _baseBLL.bacsiBLLRepo.Update(objBacsi);
                if (!flagBS)
                {
                    ViewBag.Error = "Cập nhật trạng thái lịch hẹn không thành công";
                    return View(model);
                }
                bool flag = _baseBLL.lichhenBLL.Update(entity);
                if (!flag)
                {
                    ViewBag.Error = "Cập nhật trạng thái lịch hẹn không thành công";
                    return View(model);
                }
                return Redirect("/Admin/Lichhen");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
        public IActionResult Detail(int id)
        {
            var model = new LichHenModel();
            model.ObjLichhen = _baseBLL.lichhenBLL.GetById(id);
            if (model.ObjLichhen != null)
            {
                model.ListChuandoantinhtrannuoc = _baseBLL.chuandoantinhtrangnuocBLL.GetByLichHenId(model.ObjLichhen.Id);
                model.ListChuandoanbenhcakoi = _baseBLL.chuandoanbenhcakoiBLL.GetByLichHen(model.ObjLichhen.Id);
                model.ListDonthuoc = _baseBLL.donthuocBLL.GetByLichHenId(model.ObjLichhen.Id);
            }
            return View(model);
        }
        #region chuẩn đoán bênh cá koi
        [HttpGet]
        public IActionResult AddOrEditBenh(int Id, int lhd)
        {
            var model = new Chuandoanbenhcakoi();
            var data = _baseBLL.chuandoanbenhcakoiBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            ViewBag.LichhenId = lhd;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEditBenh(Chuandoanbenhcakoi model)
        {
            try
            {
                ViewBag.LichhenId = model.LichhenId;
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
                if (model.LichhenId == 0)
                {
                    ViewBag.Error = "Thông tin lịch hẹn không được tìm thấy. Vui lòng kiểm tra lại";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    model.NgayThang = DateTime.Now;
                    bool flag = _baseBLL.chuandoanbenhcakoiBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.chuandoanbenhcakoiBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin chuẩn đoán bệnh không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TenLoaiCaKoi = model.TenLoaiCaKoi;
                    entity.ChuanDoan = model.ChuanDoan;
                    entity.HinhThucDieuTri = model.HinhThucDieuTri;
                    entity.DauHieu = model.DauHieu;
                    bool flag = _baseBLL.chuandoanbenhcakoiBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin không thành công";
                        return View(model);
                    }
                }
                return Redirect($"/Admin/Lichhen/Detail?id={model.LichhenId}");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult DeleteBenh(int id)
        {
            var entity = _baseBLL.chuandoanbenhcakoiBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.chuandoanbenhcakoiBLL.Delete(id);
                return Redirect($"/Admin/Lichhen?Detail?id={entity.LichhenId}");
            }
            return View();
        }
        #endregion
        #region chuẩn đoán tình trạng nước
        [HttpGet]
        public IActionResult AddOrEditNuoc(int Id, int lhd)
        {
            var model = new Chuandoantinhtrangnuoc();
            var data = _baseBLL.chuandoantinhtrangnuocBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            ViewBag.LichhenId = lhd;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEditNuoc(Chuandoantinhtrangnuoc model)
        {
            ViewBag.LichhenId = model.LichhenId;
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
                if (model.LichhenId == 0)
                {
                    ViewBag.Error = "Thông tin lịch hẹn không được tìm thấy. Vui lòng kiểm tra lại";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    model.NgayThang = DateTime.Now.Date;
                    bool flag = _baseBLL.chuandoantinhtrangnuocBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.chuandoantinhtrangnuocBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin chuẩn đoán tình trạng nước không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.Ph = model.Ph;
                    entity.DoCuongNuoc = model.DoCuongNuoc;
                    entity.NhietDo = model.NhietDo;
                    bool flag = _baseBLL.chuandoantinhtrangnuocBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin không thành công";
                        return View(model);
                    }
                }
                return Redirect($"/Admin/Lichhen/Detail?id={model.LichhenId}");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult DeleteNuoc(int id)
        {
            var entity = _baseBLL.chuandoantinhtrangnuocBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.chuandoantinhtrangnuocBLL.Delete(id);
                return Redirect($"/Admin/Lichhen?Detail?id={entity.LichhenId}");
            }
            return View();
        }
        #endregion
        #region đơn thuốc
        [HttpGet]
        public IActionResult AddOrEditThuoc(int Id, int lhd)
        {
            var model = new Donthuoc();
            var data = _baseBLL.donthuocBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            ViewBag.LichhenId = lhd;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEditThuoc(Donthuoc model)
        {
            ViewBag.LichhenId = model.LichhenId;
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
                if (model.LichhenId == 0)
                {
                    ViewBag.Error = "Thông tin lịch hẹn không được tìm thấy. Vui lòng kiểm tra lại";
                    return View(model);
                }
                if (model.Id == 0)
                {
                    bool flag = _baseBLL.donthuocBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.donthuocBLL.GetById(model.Id);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin đơn thuốc không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.Tenthuoc = model.Tenthuoc;
                    entity.Lieuluong = model.Lieuluong;
                    entity.hdsd = model.hdsd;
                    bool flag = _baseBLL.donthuocBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin không thành công";
                        return View(model);
                    }
                }
                return Redirect($"/Admin/Lichhen/Detail?id={model.LichhenId}");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult DeleteThuoc(int id)
        {
            var entity = _baseBLL.donthuocBLL.GetById(id);
            if (entity != null)
            {
                _baseBLL.donthuocBLL.Delete(id);
                return Redirect($"/Admin/Lichhen?Detail?id={entity.LichhenId}");
            }
            return View();
        }
        #endregion
    }
}
