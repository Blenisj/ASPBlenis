using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorldASP.Controllers
{
    public class JBlenisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       /* public string Index()
        {
            return "Welcome to my Page";
        }*/
        public IActionResult Welcome(string name, int times)
        {
            ViewData["Message"] = "Hello " +name;
            ViewData["times"] = times;
            return View();
        }

    }

}
