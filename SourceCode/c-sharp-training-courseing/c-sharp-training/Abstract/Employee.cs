using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Abstract
{
    public class Player
    {
        public int Id;
        public string Name;
        
    }

    public abstract class Team
    {
        public abstract Player ManOfTheMatch();
    }

    public class CricketTeam : Team
    {
        public override Player ManOfTheMatch()
        {
            return new Player();            
        }
    }

    public abstract class Employee
    {
        public string FName;
        public string LName;

        public int CalclulateSalary()
        {
            return 0; 
        }
        public abstract string DisplayName(string FName, string LName);
    }

    public class PaidEmployee : Employee
    {
        public override string DisplayName(string FrstName, string LstName)
        {
            FName = FrstName;
            LName = LstName;

            return FName + " " + LName;
        }
    }

    public class Program
    {
        public static void Main(string[] ar)
        {
            //Employee e = new Employee();

            PaidEmployee employee = new PaidEmployee();
            employee.DisplayName("A", "B");
                 
        }
    }
}
