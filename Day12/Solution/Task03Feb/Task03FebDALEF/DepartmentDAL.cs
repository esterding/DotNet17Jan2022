using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03FebModelsLibrary;

namespace Task03FebDALEFLibrary
{
    public class DepartmentDAL
    {
        readonly TaskContext _taskContext;

        public DepartmentDAL()
        {
            _taskContext = new TaskContext();
        }
        public bool InsertNewDepartment(Department department)
        {
            _taskContext.Departments.Add(department);
            _taskContext.SaveChanges();
            return true;
        }

        public ICollection<Department> GetAllDepartments()
        {
            List <Department> departments = _taskContext.Departments.ToList();
            if(departments.Count == 0)
            {
                Console.WriteLine("No department");
            }
            return departments;
        }

        public void DeleteDepartmentById(int id)
        {
            _taskContext.Departments.Remove(_taskContext.Departments.Single(d => d.Id == id));
            _taskContext.SaveChanges();
        }

        public bool UpdateDepartmentName(string name, int id)
        {
            Department department = _taskContext.Departments.SingleOrDefault(dp => dp.Id == id);
            if (department == null)
                return false;

            department.Name = name;
            _taskContext.SaveChanges();
            return true;
        }
    }
}
