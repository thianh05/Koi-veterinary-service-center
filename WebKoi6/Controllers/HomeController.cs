using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebKoi6.BLL;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Interface;
using WebKoi6.Models;

namespace WebKoi6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseBLL _baseBLL;
        public HomeController(IBaseBLL baseBLL)
        {
            _baseBLL = baseBLL;
        }

        public IActionResult Index()
        {
           //var data = _baseBLL.bacsiBLLRepo.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
