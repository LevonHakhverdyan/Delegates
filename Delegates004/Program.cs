using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates004
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation del = Add;
            Operation del2 = new Operation(Add);
            int res = del(5, 7);
            int res1 = del2(88, 90);
            Console.WriteLine($"{res} {res1}");

            Console.Read();
        }
        private static int Add(int x, int y) { return x + y; }
    }
}
