using CollegeWebApp.Models;

namespace CollegeWebApp.Services
{
    public class NewCalculationService : ICalculationService
    {
        public NumberModel AddTwoNumbers(NumberModel numberModel)
        {
            numberModel.Result = numberModel.FirstNumber * 2 + numberModel.SecondNumber * 2;
            return numberModel;
        }
    }
}
