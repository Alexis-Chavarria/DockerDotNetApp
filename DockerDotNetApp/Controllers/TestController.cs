using Microsoft.AspNetCore.Mvc;

namespace DockerDotNetApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
