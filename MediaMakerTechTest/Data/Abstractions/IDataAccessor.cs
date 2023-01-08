namespace MediaMakerTechTest.Data.Abstractions
{
    public interface IDataAccessor<T>
    {
        void Add(T t);
    }
}
