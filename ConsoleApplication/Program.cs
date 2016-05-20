using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GCD(14, 10));

            Console.ReadLine();
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            int r = a % b;
            return GCD(b, r);
        }

    }
}
