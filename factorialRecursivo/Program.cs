using System;
using System.Numerics;

class Solution
{
    static BigInteger extraLongFactorials(int num)
    {
        if (num == 0 || num == 1)
            return 1;
        return num * extraLongFactorials(num - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Digite el valor de n: ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("El factorial de: " + n + " es: " + extraLongFactorials(n));
        Console.ReadKey();
    }
}