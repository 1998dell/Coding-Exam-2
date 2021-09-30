using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("Enter num: ");
                    num[i] = Int32.Parse(Console.ReadLine());

                    if (!(num[i] > 1 && num[i] < 600))
                    {
                        Console.WriteLine(num[i] + " is not in range");
                        i--;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("INVALID");
                    i--;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i] + " is even, it's nearest Prime number is " + nearestPrime(num[i]));
                }
                else
                {
                    Console.WriteLine(num[i] + " is odd, it's nearest Prime number is " + nearestPrime(num[i]));
                }
            }
        }

        public static Boolean nPrime(int s)
        {
            int k = 0;
            for (int j = 1; j <= s; j++)
            {
                if (s % j == 0)
                {
                    k++;
                }
            }
            if (k == 2)
                return true;
            else
                return false;
        }
        public static int nearestPrime(int n)
        {
            int n1 = 0;
            for (int i = n; ; i++) // nearest prime num to the left
            {
                if (nPrime(i))
                {
                    n1 = i;
                    if (n == n1)
                    {
                        i++;
                    }
                    else { 
                        break;
                    }
                }
            }
            return n1;
        }
    }
}
