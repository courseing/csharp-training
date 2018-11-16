using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.StaticKeyword
{
    public static class EmployeeConfiguration
    {

        public static int _Commission = 10;
        public static int Commission
        {
            get { return _Commission; }
            set { _Commission = value; }
        }
        public static void IncreaseCommission(int IncreaseBy)
        {
            Commission = Commission + IncreaseBy;
        }
        public static void IncreaseCommission(int IncreaseBy, int Percntage)
        {
            Commission = Commission + IncreaseBy;
        }
    }

}
