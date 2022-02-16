namespace SampleMVC.Services
{
    public interface IRepo<K, T> : IAdding<K,T>
    {
        //to create cart, so use ICollection
        ICollection<T> GetAll();

        //use K instead of int, for the id might in string, not int
        T GetT(K k);
        bool Remove(K id);
        bool Update(T item);
    }
}
