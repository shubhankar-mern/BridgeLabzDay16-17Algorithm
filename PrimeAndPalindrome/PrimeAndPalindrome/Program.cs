using System;

namespace PrimeAndPalindrome
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
        public static bool isPalindrome(int val)
        {
            int num1 = val;
            int num2 = 0;
           while(num1>0)
            {
                int temp=num1 % 10;
                num2 = num2 * 10 + temp;
                num1 = num1 / 10;
            }
           if(val==num2)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            for (int i = 2; i <= 1000; i++)
            {
                if (Program.isPrime(i) == true && Program.isPalindrome(i)==true)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
