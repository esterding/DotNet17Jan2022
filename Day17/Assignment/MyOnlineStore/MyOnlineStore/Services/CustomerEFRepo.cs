using MyOnlineStore.Models;

namespace MyOnlineStore.Services
{
    public class CustomerEFRepo : IRepo<int, Customer>
    {
        private readonly CustomerContext _context;

        public CustomerEFRepo(CustomerContext context)
        {
            _context = context;
        }
        public bool Add(Customer t)
        {
            _context.Add(t);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int k)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer t, int k)
        {
            throw new NotImplementedException();
        }
    }
}
