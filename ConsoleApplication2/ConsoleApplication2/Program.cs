 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        // input : float x
        // output: a int that smallest but not smaller than x
        // idea: first change float x into integer then ++1
        //       if x is a negative than unchanged
        //       if x==n then return x
        public static int Ceil(float x)
        {
            int n = (int)x;
            if (x < 0)
                n = n;
            else
                n = n + 1;
            
            return n;
        }
        public static int Floor(float x)
        {
            int k = (int)x;
            if (x < 0 )
            {
                if (k != x)
                {
                    k = k - 1;
                }
            }
            return k;
        }
    }
}
