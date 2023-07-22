using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal partial class Employee
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee Id: " + this.EmpId);
            Console.WriteLine("Employee Name: " + this.EmpName);
        }
    }
}
