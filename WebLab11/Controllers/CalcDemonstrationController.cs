using Microsoft.AspNetCore.Mvc;
using WebLab11.Models;

namespace WebLab11.Controllers
{
    public class CalcDemonstrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult PassUsingModel()
        {
            Random random = new Random();
            int a = random.Next(11);
            int b = random.Next(11);
            var viewModel = new CalcDemonstrationViewModel()
            {
                FirstNum = a,
                SecondNum = b,
            };
            return View(viewModel);
        }
    }
}
