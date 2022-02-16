using SampleMVC.Models;

namespace SampleMVC.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        private readonly ShopContext _context;
        //Taking the context object as injection
        public CustomerRepo(ShopContext context)
        {
            _context = context;
        }
        public Customer Add(Customer item)
        {
           _context.Customers.Add(item);
            _context.SaveChanges();
            return item;
        }

        public ICollection<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetT(int k)
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == k);
            return customer;
        }

        public bool Remove(int id)
        {
            Customer customer = GetT(id);
            _context.Remove(customer);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Customer item)
        {
           Customer customer = _context.Customers.FirstOrDefault(item => item.Id == item.Id);
            if(customer != null)
            {
                customer.Id = item.Id;
                customer.Name = item.Name;
                customer.Age = item.Age;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
