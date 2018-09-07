using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRazorWorld.Pages
{
    public class HelloModel : PageModel
    {
        public long Age { get; set; }

        public string SayHello => "Hello it is";

        public void OnGet()
        {
            this.Age = 25;
        }

    }
}
namespace HelloRazorWorld.Controllers
{
    [Route("/hello")]
    public class HelloController : Controller
    {

        [Route("{Age}")]
        public IActionResult Index(long Age)
        {
            return View("jojoba");
        }

        [Route("welcome.php")]
        public IActionResult Php() {
            return View("php");
        }

        [Route("")]
        public IActionResult IndexStatic()
        {
            return View("Nothing");
        }

    }
}