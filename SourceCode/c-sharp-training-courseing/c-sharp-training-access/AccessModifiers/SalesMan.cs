using c_sharp_training.AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training_access.AccessModifiers
{
    class SalesMan  : Person
    {
        public void PintSalesManDetails()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}
