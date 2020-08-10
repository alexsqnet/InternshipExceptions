using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions1
{
    //Catch an exception
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;

            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured. You can't divide a natural number by 0");
            }

            Console.WriteLine($"Result is {div}");
        }
    }
}
