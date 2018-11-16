using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.StaticKeyword
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public static int WorkingHours { get; set; }

        static Employee()
        {
            WorkingHours = 8;
        }
        public static void ChangeWorkingHours(int NewWorkingHours)
        {
            WorkingHours = NewWorkingHours;
        }
        public Employee(int Id, string Name, int Salary)
        {
            this.Id = Id; this.Name = Name; this.Salary = Salary;
        }
    }

}
