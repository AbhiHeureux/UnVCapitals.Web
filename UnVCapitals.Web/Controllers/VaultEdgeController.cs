using Microsoft.AspNetCore.Mvc;

namespace UnVCapitals.Web.Controllers
{
    public class VaultEdgeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Services() => View();

        public IActionResult Contact() => View();

        public IActionResult Elements() => View();

        public IActionResult Insights() => View();

        public IActionResult Post() => View();
    }
}
