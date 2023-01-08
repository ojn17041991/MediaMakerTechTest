using MediaMakerTechTest.Models.Abstractions;

namespace MediaMakerTechTest.Models
{
    public class Subtraction : BaseCalculation
    {
        protected override double GetResult()
        {
            return Input1 - Input2;
        }
    }
}
