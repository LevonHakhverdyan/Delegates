using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates007
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation op = Subtract;
            Console.WriteLine(op(7, 2));
            op += Multiply;
            Console.WriteLine(op(7, 2));
            op += Add;
            Console.WriteLine(op(7, 2));
            Console.Read();
        }
        private static int Add(int x, int y) { return x + y; }
        private static int Subtract(int x, int y) { return x - y; }
        private static int Multiply(int x, int y) { return x * y; }
    }
}
