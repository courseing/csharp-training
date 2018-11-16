using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.AccessModifiers
{
   public class Person
    {
        int _Id;
        string _Name;

        private string DoB;
        internal string Age;

        protected string FirstName;
        protected internal string LastName;

        protected internal void DisplayDetails()
        {

        }
        public string Name
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
