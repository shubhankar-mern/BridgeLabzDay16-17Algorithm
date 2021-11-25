using System;

namespace StringPermutation
{
    class Program
    {
        public static string Swap(string a,int i,  int j)
        {

            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;

        }
        public static void permute(string a,int l,int r)
        {
            if(l==r)
            {
                Console.WriteLine(a);
            }
            else
            {
                for(int i=l;i<=r;i++)
                {
                    a=Swap(a,l,i );
                    permute(a, l + 1, r);
                    a=Swap(a,l,i);
                }
            }
        }
        static void Main(string[] args)
        {
            string str = "ABCDE";
            int n = str.Length;
            Program.permute(str, 0, n-1 );

        }
    }
}
