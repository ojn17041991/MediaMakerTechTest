using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;

namespace MediaMakerTechTest_Test.Stubs
{
    public class StubRequestAccessor : IDataAccessor<Request>
    {
        public void Add(Request t)
        {
            // Do nothing.
        }

        public IQueryable<Request> Get()
        {
            return new List<Request>()
            {
                new Request { Id = 1, Description = "I have stubbed this." },
                new Request { Id = 2, Description = "I have stubbed this again." },
                new Request { Id = 3, Description = "I have stubbed this yet again." }
            }.AsQueryable();
        }
    }
}
