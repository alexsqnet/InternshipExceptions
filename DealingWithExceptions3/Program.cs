using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithExceptions3
{
    //Exception properties
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Age = 30 };

            try
            {
                Console.WriteLine(person.Name.ToUpper()); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
                Console.WriteLine($"HResult: {ex.HResult}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"Data: {ex.Data.Count}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"InnerException: {ex.InnerException.Message}");
                }
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
