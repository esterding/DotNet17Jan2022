using task14022022.Models;

namespace task14022022.Services
{
    public class ProductRepo : IRepo2<int, Product>
    {
        private readonly task14022022Context _context;

        public ProductRepo(task14022022Context context)
        {
            _context = context;
        }
        public Product Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
            return item;
        }

        public bool Remove(int key)
        {
            Product product = GetT(key);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public ICollection<Product> GetAll()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }

        public Product GetT(int key)
        {
            Product product = _context.Products.FirstOrDefault(x => x.ProductId == key);
            return product;
        }

        public bool Update(Product Item)
        {
            _context.Products.Update(Item);
            _context.SaveChanges();
            return true;
        }
    }
}
