using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Inheritance
{
    public class Employee // Base / Parent
    {
        public int Id;
        public string FName, LName;

        public Employee(string FirstName, string LastName)
        {
            FName = FirstName;
            LName = LastName;
        }
        

        public string NORDisplayName(string FirstName, string LastName)
        {
            FName = FirstName;
            LName = LastName;
            return "NOR From Parent : " + FName + " " + LName;
        }

        public string DisplayName(string FirstName, string LastName)
        {
            FName = FirstName;
            LName = LastName;
            return  "From Parent : " + FName + " " + LName;
        }

        public virtual string ORDisplayName(string FirstName, string LastName)
        {
            FName = FirstName;
            LName = LastName;
            return "OR From Parent : " + FName + " " + LName;
        }

    }

    public class PaidEmployee : Employee // Derived / Child
    {
        public int BasicSalary;
        public int BonusPrcnt;
        public int Salary;

        public PaidEmployee(string FirstName, string LastName
            , int paramSalary, int pBonusPrcnt) : this(FirstName,LastName,paramSalary)
        {
            Console.WriteLine("Cons 4 Params");
            //FName = FirstName;
            //LName = LastName;
            //Salary = paramSalary;
            BonusPrcnt = pBonusPrcnt;
        }

        public PaidEmployee(string FirstName, string LastName, int paramSalary)
            :base(FirstName,LastName)
        {
            Console.WriteLine("Cons 3 Params");
            Salary = paramSalary;
        }

        

        //public PaidEmployee(string FirstName, string LastName)
        //{
        //    FName = FirstName;
        //    LName = LastName;
        //}

        public int CalculateSalary()
        {
            Salary = BasicSalary + ((BasicSalary * BonusPrcnt) / 100);
            return Salary;
        }

        public new string DisplayName(string FirstName, string LastName)
        {

            FName = FirstName;
            LName = LastName;
            return "New From Child : " + FName + " " + LName;
        }

        public override string ORDisplayName(string FirstName, string LastName) 
        {
            FName = FirstName;
            LName = LastName;
            return "OR From Child : " + FName + " " + LName;
        }

        //public string DisplayName(string FirstName, string LastName)
        //{
        //    return FName + " " + LName + "*";
        //}

        //public string DisplayName(string Prefix, string FirstName, string LastName)
        //{
        //    return Prefix + " " + FName + " " + LName + "*";
        //}

    }

    //public class Program
    //{
    //    public static void Main(string[] ar)
    //    {
    //        PaidEmployee paidemployee = new PaidEmployee("MK", "Gandhi",100,10);
    //        //Console.WriteLine("PaidEmployee paidemployee = new PaidEmployee();");
    //        //Console.WriteLine(paidemployee.DisplayName("MK", "Gandhi")); // Child
    //        //Console.WriteLine(paidemployee.ORDisplayName("MK", "Gandhi")); // Child
    //        //Console.WriteLine(paidemployee.NORDisplayName("MK", "Gandhi")); // Parent


    //        //Employee employee = new PaidEmployee("MK","Gandhi", 100);
    //        //Console.WriteLine("Employee employee = new PaidEmployee();");
    //        //Console.WriteLine(employee.DisplayName("MK", "Gandhi")); // Child
    //        //Console.WriteLine(employee.ORDisplayName("MK", "Gandhi")); // Child
    //        //Console.WriteLine(employee.NORDisplayName("MK", "Gandhi")); // Parent

    //        //Employee employee = new PaidEmployee();
    //        //Console.WriteLine("Employee employee = new PaidEmployee();");
    //        //Console.WriteLine(employee.DisplayName("MK","Gandhi"));
    //        //Console.WriteLine(employee.ORDisplayName("MK", "Gandhi"));


    //        Console.ReadLine();
    //    }
    //}
}
