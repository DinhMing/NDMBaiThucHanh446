using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(string FullName, string Address)
        {
            ViewBag.thongBao = "Xin chao " + FullName + "-" + Address;
            return View();
        }

    }
    
}