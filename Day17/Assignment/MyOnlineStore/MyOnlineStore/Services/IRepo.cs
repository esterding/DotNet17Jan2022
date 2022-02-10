namespace MyOnlineStore.Services
{
    public interface IRepo<K, T>
    {
        bool Add(T t);
        bool Delete(T t);
        bool Update(T t, K k);
        ICollection<T> GetAll();
        T Get(K k);
    }
}
