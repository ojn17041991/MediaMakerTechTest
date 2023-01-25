using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using PostmanSandbox.Data;

namespace MediaMakerTechTest.Data
{
    public class RequestAccessor : IDataAccessor<Request>
    {
        private ApplicationDbContext context;

        public RequestAccessor(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Request> Get()
        {
            return context.Requests;
        }

        public void Add(Request t)
        {
            context.Requests.Add(t);
            context.SaveChanges();
        }
    }
}
