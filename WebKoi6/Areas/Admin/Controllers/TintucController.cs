using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;
using WebKoi6.Web.Areas.Admin.Controllers.Base;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class TintucController : BaseController<TintucController>
    {
        public TintucController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        public IActionResult Index(string? search, int? page)
        {
            var model = new List<Tintuc>();
            int total = 0;
            int pageSize = 10;
            int pageNumber = page ?? 1;
            int startIndex = (pageNumber - 1) * pageSize;
            var data = _baseBLL.tintucBLL.GetListAllPaging(search, startIndex, pageSize);
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
            var model = new Tintuc();
            var data = _baseBLL.tintucBLL.GetById(Id);
            if (data != null)
            {
                model = data;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AddOrEdit(Tintuc model, IFormFile? fileUpload)
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
                var pathDb = string.Empty;
                if (fileUpload != null)
                {
                    Regex rgx = new Regex(@"(.*?)\.(jpg|bmp|png|gif|jfif|JPG|PNG|BMP|GIF|JFIF)$");
                    if (!rgx.IsMatch(fileUpload.FileName))
                    {
                        ViewBag.Error = "Định dạnh ảnh không hợp lệ";
                        return View(model);
                    }
                    string filename = DateTime.Now.ToString("yyyyMMdd") + '_' + fileUpload.FileName;
                    string folderName = DateTime.Now.ToString("yyMMdd");
                    string newPath = Path.Combine(folderName);
                    string SavePath = Path.Combine("wwwroot/Upload/Tintuc", newPath, filename);
                    var fi = new FileInfo(SavePath);
                    if (!Directory.Exists(fi.DirectoryName))
                    {
                        Directory.CreateDirectory(fi.DirectoryName);
                    }
                    using (var stream = new FileStream(SavePath, FileMode.Create))
                    {
                        fileUpload.CopyTo(stream);
                    }
                    pathDb = folderName + "\\" + filename;
                }
                if (model.MaTinTuc == 0)
                {
                    model.NgayDang = DateTime.Now;
                    model.Hinhanh = pathDb;
                    bool flag = _baseBLL.tintucBLL.Insert(model);
                    if (!flag)
                    {
                        ViewBag.Error = "Thêm mới không thảnh công";
                        return View(model);
                    }
                }
                else
                {
                    var entity = _baseBLL.tintucBLL.GetById(model.MaTinTuc);
                    if (entity == null)
                    {
                        ViewBag.Error = "Thông tin tin tức không tồn tại trong hệ thống";
                        return View(model);
                    }
                    entity.TieuDe = model.TieuDe;
                    entity.NoiDung = model.NoiDung;
                    entity.TacGia = model.TacGia;
                    entity.Hinhanh = (!string.IsNullOrEmpty(pathDb) ? pathDb : entity.Hinhanh);
                    bool flag = _baseBLL.tintucBLL.Update(entity);
                    if (!flag)
                    {
                        ViewBag.Error = "Cập nhật thông tin tin tức không thành công";
                        return View(model);
                    }
                }
                return Redirect("/Admin/Tintuc");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
