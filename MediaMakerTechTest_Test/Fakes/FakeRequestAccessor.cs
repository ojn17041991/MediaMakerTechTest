using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;

namespace MediaMakerTechTest_Test.Fakes
{
    public class FakeRequestAccessor : IDataAccessor<Request>
    {
        private IList<Request> requests = new List<Request>();

        public void Add(Request t)
        {
            requests.Add(t);
        }

        public IQueryable<Request> Get()
        {
            return requests.AsQueryable();
        }
    }
}
