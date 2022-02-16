namespace task14022022.Services
{
    public interface IRepo<K, T>
    {
        T Add(T item);
    }
}
