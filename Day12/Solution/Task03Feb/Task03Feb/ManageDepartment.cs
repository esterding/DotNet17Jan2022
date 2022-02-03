using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03FebModelsLibrary;
using Task03FebDALEFLibrary;

namespace Task03FebFE
{
    class ManageDepartment
    {
        List<Department> departments;
        DepartmentDAL departmentDAL;

        public ManageDepartment()
        {
            departmentDAL = new DepartmentDAL();
        }

        public void AddDepartment()
        {
            Department department = new Department();
            department.GetNewDepartment();
            departmentDAL.InsertNewDepartment(department);
        }

        public void DeleteDepartment()
        {
            departments = GetAllDepartments();
            int id = GetDepartmentIdFromUser();
            Department department = departments.SingleOrDefault(dp => dp.Id == id);
            if(department == null)
            {
                Console.WriteLine("There's no such department.");
                return;
            }
            departmentDAL.DeleteDepartmentById(department.Id);
            
        }

        private int GetDepartmentIdFromUser()
        {
            int id = 0;
            Console.WriteLine("Please enter the Department Id : ");
            if(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Key in the Department Id in number");
            }
            return id;
        }

        public void UpdateDepartmentName()
        {
            int id = GetDepartmentIdFromUser();
            Department department = GetDepatmentById(id);
            if(department == null)
            {
                Console.WriteLine("Invalid Id. Fail to update.");
                return;
            }
            Console.WriteLine("Please enter the new department name : ");
            string name = Console.ReadLine();
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Department name cannot be empty.");
            }
            departmentDAL.UpdateDepartmentName(name, id);
        }

        private Department GetDepatmentById(int id)
        {
            departments = GetAllDepartments();
            Department department = departments.SingleOrDefault(dp => dp.Id == id);
            return department;
        }

        public List<Department> GetAllDepartments()
        {
            departments = null;
            try
            {
                departments = departmentDAL.GetAllDepartments().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return departments;
        }

        public void PrintAllDepartments()
        {
            departments = GetAllDepartments();
            foreach(var dep in departments)
            {
                Console.WriteLine(dep);
            }
        }
    }
}
