using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            String CorrectUser = "root";
            String CorrectPassword = "letmein";

            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Input a username: ");
                String response1 = Console.ReadLine();

                Console.Write("Input a password: ");
                String response2 = Console.ReadLine();

                if (response1 == CorrectUser && response2 == CorrectPassword)
                {
                    Console.WriteLine("Username and password authenticated... you may proceed.");
                    break;
                }

                if (i == 2)
                {
                    Console.WriteLine("Too many incorrect login attempts! Try again later!");   
                }
            }

        }
    }
}
