using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Numerics;

class Solution
{
    // Complete the extraLongFactorials function below.
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

        Console.Write("El factorial de: "+ n + " es: " + extraLongFactorials(n));
        Console.ReadKey();
    }
}