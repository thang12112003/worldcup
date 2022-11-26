using Microsoft.AspNetCore.Mvc;

namespace ttt.Controllers
{
    public class HiWorldCupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(int doi1, int doi2, int matran)
        {
            ViewData["doi1"] = "result  :" + doi1;
            ViewData["doi2"] = doi2;
            ViewData["matran"] = matran;
            return View();
        }
    }
}
