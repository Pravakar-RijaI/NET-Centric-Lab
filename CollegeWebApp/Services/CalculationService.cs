using CollegeWebApp.Models;

namespace CollegeWebApp.Services
{
    public class CalculationService : ICalculationService
    {
        public NumberModel AddTwoNumbers(NumberModel numberModel)
        {
            numberModel.Result = numberModel.FirstNumber + numberModel.SecondNumber;
            return numberModel;
        }
    }
}
