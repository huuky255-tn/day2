using Microsoft.AspNetCore.Mvc;

namespace day2.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting()
        {
            return "Chao mung cac ban den voi mon hoc";
        }

        public String Welcome(int id, string name)
        {
            return $"xin chao {id} - {name}, chúc bạn học tốt môn học ASP.NET";
        }

        //IactionResult
        public IActionResult Welcome1(int numTimes, string name)
        {
            ViewBag.Id = numTimes;
            ViewData["Name"] = name;
            return View();
        }
    }
}
