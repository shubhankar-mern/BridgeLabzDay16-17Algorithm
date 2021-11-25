using System;

namespace BinarySearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lo = 0;
            int hi = 1024;
            int key = Convert.ToInt32(Console.ReadLine());
            while (lo<=hi)
            {
                int mid = (lo + hi) / 2;
                Console.WriteLine("finally " + mid+" the number");
                bool ans = Convert.ToBoolean(Console.ReadLine());
                if(ans==true)
                {
                    Console.WriteLine(mid);
                }
                else
                {
                    Console.WriteLine("is the number greter(press true is applicsble) ");
                    bool ans1 = Convert.ToBoolean(Console.ReadLine());
                    if(ans1==true)
                    {
                        lo = mid + 1;
                       
                    }
                    else
                    {
                        hi = mid - 1;
                    }

                }
            }
        }
    }
}
