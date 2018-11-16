using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.AccessModifiers
{
    public class Employee : Person
    {
        public void PrintEmployee()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
        //internal string FirstName;
    }
}
