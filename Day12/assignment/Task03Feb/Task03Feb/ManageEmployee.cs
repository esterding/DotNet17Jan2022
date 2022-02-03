using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03FebModelsLibrary;
using Task03FebDALEFLibrary;

namespace Task03FebFE
{
    public class ManageEmployee
    {
        List<Employee> employees;
        EmployeeDAL employeeDAL;

        public ManageEmployee()
        {
            employeeDAL = new EmployeeDAL();
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            employee = GetEmployeeInformation();
            employeeDAL.CreateNewEmployee(employee);
        }

        public Employee GetEmployeeInformation()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee name : ");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Plase enter the employee age : ");
            int age = 0;
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Enter the age in number. Try again.");
            }
            employee.Age = age;
            ManageDepartment mngDept = new ManageDepartment();
            mngDept.PrintAllDepartments();
            Console.WriteLine("Please key in the department Id : ");
            int deptId = 0;
            while (!Int32.TryParse(Console.ReadLine(), out deptId))
            {
                Console.WriteLine("Enter the department ID instead of name. Try again.");
            }
            employee.Department_Id = deptId;
            return employee;
        }

        public void EditEmployeeAge()
        {
            int id = GetEmployeeIdFromUser();
            Employee employee = GetEmployeeById(id);
            if(employee == null)
            {
                Console.WriteLine("Invalid id.");
                return;
            }
            Console.WriteLine("Please enter the employee age : ");
            int age = 0;
            if (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Key in the age in number, please try again.");
            }
            employeeDAL.UpdateEmployeeAge(id, age);
        }

        internal void PrintAllEmployees()
        {
            employees = GetAllEmployees();
            foreach(var ep in employees)
            {
                Console.WriteLine(ep);
            }

        }

        public Employee GetEmployeeById(int id)
        {
            List<Employee> employees = GetAllEmployees();
            Employee employee = employees.SingleOrDefault(ep => ep.Id == id);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            employees = null;
            try
            {
                employees = employeeDAL.GetAllEmployees().ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;
        }

        private int GetEmployeeIdFromUser()
        {
            Console.WriteLine("Please enter the employee Id : ");
            int id = 0;
            if(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid, please try again.");
            }
            return id;
        }

        public void EditEmployeeDepartment()
        {
            int id = GetEmployeeIdFromUser();
            employees = GetAllEmployees();
            Employee employee = employees.SingleOrDefault(ep => ep.Id == id);
            if (employee == null)
                return;
            ManageDepartment mngDept = new ManageDepartment();
            mngDept.PrintAllDepartments();
            Console.WriteLine("Please enter the new department Id.");
            int deptId;
            while(!Int32.TryParse(Console.ReadLine(), out deptId))
            {
                Console.WriteLine("Please enter the department Id.");
            }
            employeeDAL.UpdateEmployeeDepartment(id, deptId);
        }


    }
}
