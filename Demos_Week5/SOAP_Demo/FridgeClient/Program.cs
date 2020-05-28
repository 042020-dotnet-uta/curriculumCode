using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeClient.ServiceReference1;

namespace FridgeClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            FridgeClient.ServiceReference1.FridgeClient client = new FridgeClient.ServiceReference1.FridgeClient();

            client.AddFood(2, "banana");

            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();

        }
    }
}
