using Microsoft.AspNetCore.Mvc;
using WebKoi6.BLL;
using WebKoi6.DAL.Models;

namespace WebKoi6.Web.Controllers
{
    public class TintucController : Controller
    {
        private readonly IBaseBLL _baseBLL;
        public TintucController(IBaseBLL baseBLL)
        {
            _baseBLL = baseBLL;
        }
        public IActionResult Index(int Id)
        {
            Tintuc model = new Tintuc();
            var data = _baseBLL.tintucBLL.GetById(Id);
            if(data != null)
            {
                model = data;
            }
            return View(model);
        }
    }
}
