using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training_access.AccessModifiers
{
    public class ManageSalesMan
    {
        SalesMan s1 = new SalesMan();
        public void PrintSalesManDetails()
        {
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.LastName); // Compile Error
        }
    }
}
