using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSolver
{
    class PrimeSolver
    {
        static void Main(string[] args)
        {
            for (int x = 2; x < 1000; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.Write(x + ", ");

                isPrime = 0;
            }
            Console.ReadKey();

        }
    }
}
