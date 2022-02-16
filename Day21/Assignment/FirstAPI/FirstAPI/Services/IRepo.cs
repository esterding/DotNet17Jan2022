namespace FirstAPI.Services
{
    public interface IRepo<K, T>
    {
        T Get(K key);
        T Update(K key, T item);
        T Delete(K key);
        ICollection<T> GetAll();
        T Add(T item);
        
    }
}
