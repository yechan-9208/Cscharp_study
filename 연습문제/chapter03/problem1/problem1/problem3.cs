using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class problem3
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resulta = 0;

            plus(a, b, out resulta);

            Console.WriteLine("{0} + {1} = {2}",a,b,resulta);

            double x = 2.4;
            double y = 3.1;
            double resultb = 0;

            plus(x, y, out resultb);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultb);
        }

        public static void plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
