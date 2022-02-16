using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class EmployeeRepo : IRepo<int, Employee>
    {
        private readonly APIContext _context;

        public EmployeeRepo(APIContext context)
        {
            _context = context;
        }
        public Employee Add(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int key)
        {
            var employee = Get(key);
            if(employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }

        public Employee Get(int key)
        {
            Employee employee = _context.Employees.SingleOrDefault(e => e.Id == key);
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee Update(int key, Employee item)
        {
            Employee employee = _context.Employees.SingleOrDefault(e => e.Id == key);
            if(employee != null)
            {
                employee.Name = item.Name;
                employee.Role = item.Role;
                _context.Employees.Update(employee);
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
