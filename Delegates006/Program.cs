using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates006
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate void Message();

        static void Main(string[] args)
        {
            Message mes = Hello;
            mes();
            Operation op = Add;
            int res = op(3, 4);
            Console.WriteLine(res);
            Console.Read();
        }
        private static void Hello() { Console.WriteLine("Hello"); }
        private static int Add(int x, int y) { return x + y; }
    }
}
