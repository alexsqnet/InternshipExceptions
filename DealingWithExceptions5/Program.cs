using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions5
{
    //Re-throwing an Exception
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            try
            {
                mc.Method();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught here");
            }

            Console.WriteLine("Last Statement");
        }
    }

    class MyClass
    {
        public void Method()
        {
            try
            {
                int x = 0;
                int sum = 100 / x;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
