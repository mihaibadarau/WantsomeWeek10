using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10
{

    class Program
    {
        public static T adunare<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        static void Main(string[] args)
        {
            int x = 12;
            int y = 24;
            float z = 11.23f;
            float w = 22.54f;

            Console.WriteLine(adunare(x, y));
            Console.WriteLine(adunare(z, w));
            Console.ReadKey();
        }
    }
}
