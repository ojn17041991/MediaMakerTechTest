using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaMakerTechTest.Controllers
{
    // You shouldn't add requests like this.
    // Just wanting to play with Moq and need a controller to test.

    [Route("api/Requests")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private IDataAccessor<Request> dataAccessor;

        public RequestController(IDataAccessor<Request> dataAccessor)
        {
            this.dataAccessor = dataAccessor;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(dataAccessor.Get());
        }

        [HttpPost]
        public ActionResult Add(Request request)
        {
            dataAccessor.Add(request);

            return Ok();
        }
    }
}
