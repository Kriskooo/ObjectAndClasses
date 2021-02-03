using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger(n);
        }

        private static void BigInteger(int n)
        {
            BigInteger factiorial = 1;
            for (int i = n; i >= 1; i--)
            {

                factiorial *= i;
            }
            Console.WriteLine(factiorial);
        }
    }
}
