using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions01
{
    //Throw an exception
    class Program
    {
        static void Main(string[] args)
        {
            ShowMessage("Dealing with Exceptions");
            ShowMessage("");
        }

        static void ShowMessage(string message) 
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("Invalid message body!");
            }

            Console.WriteLine(message);
        }
    }
}
