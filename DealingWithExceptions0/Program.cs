using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions0
{
    //Uncaught Exception
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 100 / x;

            Console.WriteLine(div);
            Console.ReadLine();
        }
    }
}
