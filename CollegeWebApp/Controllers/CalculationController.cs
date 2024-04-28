using CollegeWebApp.Models;
using CollegeWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CollegeWebApp.Controllers
{
    public class CalculationController : Controller
    {
        private ICalculationService _calculator;

        public CalculationController(ICalculationService calculator)
        {
            _calculator = calculator;
        }

        [HttpGet]
        public IActionResult AddTwoNumbers()
        {
            NumberModel numberModel = new NumberModel();
            return View(numberModel);
        }

        [HttpPost]
        public IActionResult AddTwoNumbers(NumberModel numberModel)
        {
            if (ModelState.IsValid)
            {
                NumberModel number = _calculator.AddTwoNumbers(numberModel);
                return View(number);
            }
            else
                return View(numberModel);
        }
    }
}
