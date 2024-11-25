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
            int firstNum = random.Next(11);
            int secondNum = random.Next(11);
            var viewModel = new CalcDemonstrationViewModel()
            {
                FirstNum = firstNum,
                SecondNum = secondNum,
            };
            return View(viewModel);
        }

        public ActionResult PassUsingViewData()
        {
            Random random = new Random();
            int firstNum = random.Next(11);
            int secondNum = random.Next(11);
            ViewData["FirstNum"] = firstNum;
            ViewData["SecondNum"] = secondNum;
            ViewData["Addition"] = firstNum + secondNum;
            ViewData["Division"] = (secondNum != 0 ? (firstNum / secondNum) : "Деление на ноль");
            ViewData["Multiplication"] = firstNum * secondNum;
            ViewData["Subtraction"] = firstNum - secondNum;
            return View();
        }

        public ActionResult PassUsingViewBag()
        {
            Random random = new Random();
            int firstNum = random.Next(11);
            int secondNum = random.Next(11);
            ViewBag.FirstNum = firstNum;
            ViewBag.SecondNum = secondNum;
            ViewBag.Addition = firstNum + secondNum;
            ViewBag.Division =(secondNum != 0 ? (firstNum / secondNum).ToString() : "Деление на ноль");
            ViewBag.Multiplication = firstNum * secondNum;
            ViewBag.Subtraction = firstNum - secondNum;
            return View();
        }

        public ActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
