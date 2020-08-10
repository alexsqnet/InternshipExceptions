using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    //Inner Exception
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new ArgumentException();
                }

                catch (ArgumentException e)
                {
                    //make sure this path does not exist
                    if (File.Exists("d:\\test\\doc.txt") == false)
                    {
                        throw new FileNotFoundException("File Not found when trying to write argument exception to the file", e);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(String.Concat(e.StackTrace, e.Message));

                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner Exception");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }

            Console.ReadLine();
        }
    }
}
