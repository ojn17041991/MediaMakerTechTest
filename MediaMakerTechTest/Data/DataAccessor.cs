using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using PostmanSandbox.Data;

namespace MediaMakerTechTest.Data
{
    public class DataAccessor : IDataAccessor<Request>
    {
        private ApplicationDbContext context;

        public DataAccessor(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Request t)
        {
            context.Requests.Add(t);
            context.SaveChanges();
        }
    }
}
