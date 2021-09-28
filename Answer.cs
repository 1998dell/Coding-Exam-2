namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[5];
            
            for (int i = 0; i<5; i++)
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
                    Console.WriteLine(num[i] + " is even, it's nearest Prime number is " + nearestPrime(num[i]));
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
            int d1 = 0, d2 = 0, n1 = 0, n2 = 0;
            for (int i = n; ; i--)
            {
                if (nPrime(i))
                {
                    d1 = n - i;
                    n2 = i;
                    break;
                }
            }
            for (int i = n; ; i++)
            {
                if (nPrime(i))
                {
                    d1 = i - n;
                    n1 = i;
                    break;
                }
            }


            if (d1 <= d2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
}
