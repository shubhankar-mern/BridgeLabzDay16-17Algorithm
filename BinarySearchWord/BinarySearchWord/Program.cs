using System;

namespace BinarySearchWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]{"abel","alex","animal","break","zebra","nanital" };
            Array.Sort(words);
            int n = words.Length;
            int lo = 0;
            int hi = n - 1;
            string key ="zebra";
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(words[i]);
            }
            while(lo<=hi)
            {
                int mid = lo + (hi - lo) / 2;
                if(words[mid]==key)
                {
                   Console.WriteLine(mid);
                    break;
                }
                else if(words[mid].CompareTo(key)>0)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }

            }
        }
    }
}
