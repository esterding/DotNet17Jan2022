using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03FebModelsLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Department_Id { get; set; }

        [ForeignKey("Department_Id")]
        public Department Department { get; set; }

        public override string ToString()
        {
            return "Employee Id : " + Id + "\tEmployee Name : " + Name + "\tEmployee Age : " + Age + "\tDepartment Id : " + Department_Id;
        }
    }
}
