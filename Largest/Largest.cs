using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest
{
    class Largest
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int response1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int response2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 3rd number: ");
            int response3 = Convert.ToInt32(Console.ReadLine());


            if (response1 > response2 && response1 > response3)
            {
                Console.WriteLine("The 1st number is the largest of the three.");
            }

            if (response2 > response1 && response2 > response3)
            {
                Console.WriteLine("The 2nd number is the largest of the three.");
            }

            if (response3 > response1 && response3 > response2)
            {
                Console.WriteLine("The 3rd number is the largest of the three.");
            }
        }
    }
}
