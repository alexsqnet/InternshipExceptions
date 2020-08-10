using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    //User defined exceptions
    class Program
    {
        static void Main(string[] args)
        {
            DeliverToClient(2020);

            Console.ReadLine();
        }

        static void DeliverToClient(int clientId) 
        {
            try
            {
                var repository = new ClientRepository();

                var client = repository.GetClientById(clientId);

                if (client == null)
                {
                    throw new ClientDeliveryException(string.Format("Unable to find a client by id {0}", clientId));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught here" + ex.ToString());
            }
        }
    }

    public class ClientDeliveryException : Exception
    {
        public ClientDeliveryException(string message)
           : base(message)
        {
        }
    }

    public class ClientRepository
    {
        public object GetClientById(int id) 
        {
            //some logic ...

            //return client from db
            return null;
        } 
    }

}
