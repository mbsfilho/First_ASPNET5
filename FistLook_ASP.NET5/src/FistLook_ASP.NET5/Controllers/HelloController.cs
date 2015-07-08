using Microsoft.AspNet.Mvc;
using System.Reflection;

namespace FistLook_ASP.NET5.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
    }
}