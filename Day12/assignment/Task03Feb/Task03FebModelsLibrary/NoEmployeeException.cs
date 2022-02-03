using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03FebModelsLibrary
{
    public class NoEmployeeException : Exception
    {
        string message;

        public NoEmployeeException()
        {
            message = "No Employee available.";
        }

        public override string Message => message;
    }
}
