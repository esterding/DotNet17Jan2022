using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03FebFE
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            ManageEmployee mngEmp = new ManageEmployee();
            ManageDepartment mngDept = new ManageDepartment();

            do
            {
                Console.WriteLine("Please select an option to start.");
                Console.WriteLine("1. Add department");
                Console.WriteLine("2. Edit department name");
                Console.WriteLine("3. Print Departments");
                Console.WriteLine("4. Add employee");
                Console.WriteLine("5. Edit employee age");
                Console.WriteLine("6. Edit employee department");
                Console.WriteLine("7. Print all employees");
                Console.WriteLine("8. Exit");

                while (!Int32.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Please key in a number from 1-8");
                }

                switch (selection)
                {
                    case 1:
                        mngDept.AddDepartment();
                        break;
                    case 2:
                        mngDept.UpdateDepartmentName();
                        break;
                    case 3:
                        mngDept.PrintAllDepartments();
                        break;
                    case 4:
                        mngEmp.AddEmployee();
                        break;
                    case 5:
                        mngEmp.EditEmployeeAge();
                        break;
                    case 6:
                        mngEmp.EditEmployeeDepartment();
                        break;
                    case 7:
                        mngEmp.PrintAllEmployees();
                        break;
                    case 8:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid. Please try again.");
                        break;
                }

            } while (selection != 8);
        }
    }
}
