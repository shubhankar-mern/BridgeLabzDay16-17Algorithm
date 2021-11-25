using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = Convert.ToString(ch1);
            string val2 = Convert.ToString(ch2);//new string(ch1);
            if(val1==val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");

            }
            
        }
    }
}
