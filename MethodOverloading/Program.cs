using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(Add( 1, 1));
            Console.WriteLine();
            Console.WriteLine(Add( 5.5M, 6.1M));
            Console.WriteLine();
            Console.WriteLine(Add(1, 1, false));
            Console.WriteLine(Add(1, 1, true));
            Console.WriteLine(Add(1, 0, true));
        }

        // 1. Create an Add method: 
        //  b. This Add method takes 2 integer parameters

        public static int Add(int left, int right)
        {
            return left + right;
        }

        // 2. Create an overload of the Add method:
        //  a. This Add method needs to have 2 decimal parameters

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        // 3. Create another overload of the Add method:
        //  a. This Add method returns a string
        //  b. And this Add method takes 3 parameters (2 Integer parameters and 1 boolean parameter)

        public static string Add(int left, int right, bool showDollars)
        {
            int sum = left + right;
            if (showDollars)
            {
                if (sum == 1) 
                {
                    return $"{sum} dollar";
                } else 
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}