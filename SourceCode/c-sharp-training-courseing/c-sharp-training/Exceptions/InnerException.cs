using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.Exceptions
{
    using System;
    using System.IO;

    public class InnerException
    {
        public void RaiseException()
        {
            try
            {
                try
                {
                    throw new ArgumentException();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Arugment Exception");
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.Message);
                    //make sure this path does not exist
                    if (File.Exists("file://false") == false)
                    {
                        throw new FileNotFoundException("File Not found", e);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);

                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner Exception");
                    Console.WriteLine(e.InnerException.StackTrace);
                    Console.WriteLine(e.InnerException.Message);
                }

            }
            Console.ReadLine();
        }
    }
}
