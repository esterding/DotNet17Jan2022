using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        private readonly APIContext _context;

        public CustomerRepo(APIContext context)
        {
            _context = context;
        }
        public Customer Add(Customer item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Customer Delete(int key)
        {
            var customer = Get(key);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            return customer;
        }

        public Customer Get(int key)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == key);
            if (customer != null)
                return customer;
            return null;
        }

        public ICollection<Customer> GetAll()
        {
            var customers = _context.Customers.ToList();
            return customers;
        }

        public Customer Update(int key, Customer item)
        {
            var cus = Get(key);
            if(cus != null)
            {
                cus.Age = item.Age;
                cus.Name = item.Name;
                _context.Customers.Update(cus);
                _context.SaveChanges();
                return cus;
            }
            return null;
        }
    }
}
