using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaMakerTechTest.Controllers
{
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
    }
}
