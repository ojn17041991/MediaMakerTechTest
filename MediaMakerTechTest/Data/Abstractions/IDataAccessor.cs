namespace MediaMakerTechTest.Data.Abstractions
{
    public interface IDataAccessor<T>
    {
        IQueryable<T> Get();

        void Add(T t);
    }
}
