using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommenSubsequence_DynamicProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            //string p = "abcedfgh";
            //string q = "abwrdfg";

            string p = "abck";
            string q = "abcdedfg";

            int[,] temp = new int[p.Length + 1, q.Length + 1];

            //initialized with -1

            for(int i=0;i<p.Length+1;i++)
            {
                for(int j=0;j<q.Length+1;j++)
                {
                    temp[i, j] = -1;
                }
            }

            int returnResult = Lcs(p,q,p.Length,q.Length,temp);

            Console.WriteLine("Longest Common Subsequence " + returnResult);
            Console.ReadLine();
        }

        public static int Lcs(string x,string y,int m,int n,int[,] temp)
        {
            if (m == 0 || n == 0) return 0;

            if (temp[m, n] != -1)
                return temp[m, n];
            if (x[m - 1] == y[n - 1])
                return temp[m, n] = 1 + Lcs(x, y, m - 1, n - 1, temp);
            else
                return temp[m, n] = Math.Max(Lcs(x, y, m - 1, n, temp), Lcs(x, y, m, n - 1, temp));
        }
    }
}
