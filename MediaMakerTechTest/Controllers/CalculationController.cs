using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MediaMakerTechTest.Controllers
{
    [Route("api")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private IDataAccessor<Request> dataAccessor;

        public CalculationController(IDataAccessor<Request> dataAccessor)
        {
            this.dataAccessor = dataAccessor;
        }

        [HttpGet("[action]/{input1}, {input2}")]
        public string Add(double input1, double input2)
        {
            dataAccessor.Add(new Request() { Description = $"Adding {input1} to {input2}" });

            return JsonSerializer.Serialize(
                new Addition()
                {
                    Input1 = input1,
                    Input2 = input2
                }
            );
        }

        [HttpGet("[action]/{input1}, {input2}")]
        public string Subtract(double input1, double input2)
        {
            dataAccessor.Add(new Request() { Description = $"Subtracting {input1} by {input2}" });

            return JsonSerializer.Serialize(
                new Subtraction()
                {
                    Input1 = input1,
                    Input2 = input2
                }
            );
        }

        [HttpGet("[action]/{input1}, {input2}")]
        public string Multiply(double input1, double input2)
        {
            dataAccessor.Add(new Request() { Description = $"Multiplying {input1} by {input2}" });

            return JsonSerializer.Serialize(
                new Multiplication()
                {
                    Input1 = input1,
                    Input2 = input2
                }
            );
        }

        [HttpGet("[action]/{input1}, {input2}")]
        public string Divide(double input1, double input2)
        {
            dataAccessor.Add(new Request() { Description = $"Dividing {input1} by {input2}" });

            return JsonSerializer.Serialize(
                new Division()
                {
                    Input1 = input1,
                    Input2 = input2
                }
            );
        }
    }
}
