namespace task14022022.Services
{
    public interface IRepo2<K, T> : IRepo<K, T>
    {
        bool Update(T Item);
        bool Remove(K key);
        ICollection<T> GetAll();
        T GetT(K key);
    }
}
