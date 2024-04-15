using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg et tal mellem 1-4");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput > 0 && UserInput < 5)
            {
                Console.WriteLine("Meget godt");
            }
            else
            {
                Console.WriteLine("Du er dum");
            }

            Console.ReadLine();
        }
    }
}
