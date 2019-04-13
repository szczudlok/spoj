using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader input = new StringReader(test);

            int n = int.Parse(input.ReadLine());
            int[] s = new int[n];

            string[] ss =  input.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Debug.Assert(s.Length == ss.Length);
            for (int i = 0; i < n; i++)
                s[i] = int.Parse(ss[i]);



            int m = int.Parse(input.ReadLine());
            int[] q = new int[m];

            string[] qq = input.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Debug.Assert(q.Length == qq.Length);
            for (int i = 0; i < n; i++)
                q[i] = int.Parse(ss[i]);


            string wynik = "";
            for (int i = 0; i < Math.Min(n, m); i++)
            {
                if (s[i] == q[i])
                    wynik += (i + 1) + " ";
            }
            Console.WriteLine(wynik);
        }
        static string test = @"5
    -2 -2 -1 1 4
    6
    -3 -2 -1 1 2 3";

        static string test1 = "5\n-2 -2 -1 1 4\n6\n-3 -2 -1 1 2 3";
    }

}