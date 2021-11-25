using System;

namespace PrimeNumberAll
{
    class Program
    {

       public static bool isPrime(int val)
        {
            int count = 0;
            for (int j = 2; j * j <= val; j++)
            {
                if (val % j == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

            for (int i = 2; i <= 1000; i++)
            {
                if (Program.isPrime(i) == true)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
