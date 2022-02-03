using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03FebModelsLibrary;

namespace Task03FebDALEFLibrary
{
    public class EmployeeDAL
    {
        readonly TaskContext _taskContext;

        public EmployeeDAL()
        {
            _taskContext = new TaskContext();
        }
        public bool CreateNewEmployee(Employee employee)
        {
            _taskContext.Employees.Add(employee);
            _taskContext.SaveChanges();
            return true;
        }

        public ICollection<Employee> GetAllEmployees()
        {
            List<Employee> employees = _taskContext.Employees.ToList();
            if (employees.Count == 0)
                throw new NoEmployeeException();
            return employees;
        }

        public bool UpdateEmployeeAge(int id, int age)
        {
            Employee employee = _taskContext.Employees.SingleOrDefault(ep => ep.Id == id);
            if (employee == null)
                return false;
            employee.Age = age;
            _taskContext.SaveChanges();
            return true;
        }

        public void UpdateEmployeeDepartment(int id, int deptId)
        {
            Employee employee = _taskContext.Employees.SingleOrDefault(ep => ep.Id == id);
            employee.Department_Id = deptId;
            _taskContext.SaveChanges();
        }
    }
}
