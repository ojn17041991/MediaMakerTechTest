using MediaMakerTechTest.Models.Abstractions;

namespace MediaMakerTechTest.Models
{
    public class Division : BaseCalculation
    {
        protected override double GetResult()
        {
            return Input1 / Input2;
        }
    }
}
