using Microsoft.EntityFrameworkCore;

namespace PizzaApplication.Models
{
    public class PizzaShopContext : DbContext
    {
        private readonly PizzaShopContext _context;

        public PizzaShopContext(PizzaShopContext context)
        {
            _context = context;
        }
    }
}
