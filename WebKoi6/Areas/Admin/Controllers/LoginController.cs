using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using WebKoi6.BLL;
using WebKoi6.BLL.Extensions;
using WebKoi6.Web.Areas.Admin.Controllers.Base;
using WebKoi6.Web.Areas.Admin.Models;

namespace WebKoi6.Web.Areas.Admin.Controllers
{
    public class LoginController : BaseController<LoginController>
    {
        public LoginController(IBaseBLL @baseBLL, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(@baseBLL, httpContextAccessor, configuration)
        {

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    ViewBag.Error = "Vui lòng nhập tài khoản và mật khẩu";
                    return View();
                }
                string passHash = HashExtension.sha256(password.Trim());
                var data = _baseBLL.taiKhoanBLL.CheckLogin(username.Trim(), passHash);
                if(data == null)
                {
                    ViewBag.Error = "Thông tin tài khoản hoặc mật khẩu không chính xác";
                    return View();
                }
                SetUser(new AdminSession
                {
                    SessionId = _contextAccessor.HttpContext.Session.Id,
                    Username = data.Username,
                    UserId = data.Id
                });
                return Redirect("/Admin/Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            ClearUser();
            return Redirect("/Admin/Login/Index");
        }
    }
}
