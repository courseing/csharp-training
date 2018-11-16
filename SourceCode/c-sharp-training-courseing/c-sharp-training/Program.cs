using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_training.StaticKeyword;

namespace c_sharp_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee(1, "Whale", 2000);
            Employee.WorkingHours = 8;
            Employee.ChangeWorkingHours(8);
        }
    }
}
