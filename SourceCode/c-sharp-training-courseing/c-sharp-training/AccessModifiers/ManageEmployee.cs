using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.AccessModifiers
{
    class ManageEmployee
    {
        Employee e1 = new Employee();

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine();
            Console.WriteLine(e1.LastName);
        }
    }
}
