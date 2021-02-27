using System;
using System.Numerics;

namespace factorialConIterador
{
    class factorialConIterador
    {
        static void extraLongFactorials(int num)
        {
            BigInteger fact = new BigInteger();
            fact = BigInteger.One;

            for (int i = 1; i <= num; i++)
            {
                fact = BigInteger.Multiply(fact, i);
            }
            Console.Write("El factorial de: " + num + " es: " + fact);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite el valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);

            Console.ReadKey();
        }
    }
}

