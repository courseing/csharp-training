using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Interfaces
{
    public interface IPerson
    {
        string Address();
        string IdProof();
        string AdharCard();
    }

    public interface IQualification
    {
        //string Address();
        //string IdProof();
        //string AdharCard();
    }

    public interface IQualifiedPerson : IPerson, IQualification
    {

    }

    public class Programmer : IQualifiedPerson
    {
        public string Address()
        {
            return "";
        }

        public string IdProof()
        {
            return "";
        }

        public string AdharCard()
        {
            return "";
        }
    }

    public class Doctor : IPerson
    {
        public string Address()
        {
            return "";
        }

        public string IdProof()
        {
            return "";
        }
        public string AdharCard()
        {
            return "";
        }
    }


    public class Program
    {
        public static void Main(string[] ar)
        {

            IPerson p = new Programmer();
            p.Address();
            p.AdharCard();
            p.IdProof();

            IPerson p1 = new Doctor();
            p1.

        }
    }
}
