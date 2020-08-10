using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions2
{
    //try, catch, finally blocks
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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }

            Console.WriteLine($"Result is {div}");
        }
    }
}
