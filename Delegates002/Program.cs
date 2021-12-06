using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates002
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation del = Add;
            int result = del(4, 5);
            Console.WriteLine(result);

            del = Multiply;
            result = del(4, 5);
            Console.WriteLine(result);

            Console.Read();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
