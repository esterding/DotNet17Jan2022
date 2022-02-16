namespace SampleMVC.Services
{
    public interface IAdding<K, T>
    {
        T Add(T item);
    }
}
