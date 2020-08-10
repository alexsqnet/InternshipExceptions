using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = null;

            try
            {
                wc = new WebClient(); //downloading a web page

                var resultData = wc.DownloadString("http://google.com");
            }
            catch (ArgumentNullException ex)
            {
                //code specifically for a ArgumentNullException
            }
            catch (WebException ex)
            {
                //code specifically for a WebException
            }
            catch (Exception ex)
            {
                //code for any other type of exception
            }
            finally
            {
                //call this if exception occurs or not
                //in this example, dispose the WebClient
                wc?.Dispose();
            }
        }
    }
}
