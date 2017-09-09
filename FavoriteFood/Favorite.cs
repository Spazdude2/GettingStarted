using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite
{
    class Favorite
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favorite food: ");
            String response = Console.ReadLine();

            //int num = Convert.ToInt32(Console.ReadLine());
            if (response == "Pizza" || response == "pizza")
            {
                Console.WriteLine("We good bro");
            }

            else
            {
                Console.WriteLine("Get out of my face");
            }
        }
    }
}
