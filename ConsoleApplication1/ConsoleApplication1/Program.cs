using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (IsOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
    }
}
