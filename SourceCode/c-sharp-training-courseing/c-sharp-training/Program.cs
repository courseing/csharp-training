using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_training.StaticKeyword;
using c_sharp_training.Exceptions;

namespace c_sharp_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            bool IsContinue = false;
            Player p;

            do
            {
                
                Console.WriteLine("Enter Player Name");
                p = new Player();
                p.Name = Console.ReadLine();
                try
                {
                    t.AddPlayer(p);
                    Console.WriteLine("Enter True to continue else enter false");
                    IsContinue = Convert.ToBoolean(Console.ReadLine());
                }
                catch (IndexOutOfRangeException exc)
                {
                    Console.WriteLine("Cannot Add more players.");
                    Console.WriteLine(exc.Message);
                }
                catch(FormatException exc)
                {
                    Console.WriteLine("Please Enter true or false");
                    Console.WriteLine(exc.Message);
                    IsContinue = false;
                }
                catch (TeamException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    Console.WriteLine("Thank you for providing Player Details");
                }
            } while (IsContinue);


            Console.WriteLine("Palyers Data Entry completed");
            Console.ReadLine();
        }
    }
}
