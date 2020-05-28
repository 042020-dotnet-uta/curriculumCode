using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeClient1.ServiceReference1;

namespace FridgeClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            FridgeClient client = new FridgeClient();

            client.AddFood(4, "banana");
            client.AddFood(5, "pear");

            client.AddFood(6, "tomato");

            client.AddFood(7, "pen");

            client.AddFood(8, "bottle");

            var totalFood = client.Food();

            foreach (var f in totalFood)
            {
                Console.WriteLine($"There are {f.Value} {f.Key}'s in the fridge.");
            }

            client.SubtractFood(4, "bottle");

            var totalFood1 = client.Food();

            foreach (var f in totalFood1)
            {
                Console.WriteLine($"There are {f.Value} {f.Key}'s in the fridge.");
            }


            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();

        }
    }
}
