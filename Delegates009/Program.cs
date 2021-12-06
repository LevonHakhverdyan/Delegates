using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates009
{
    delegate T Operation<T, K>(K val);
    class Program
    {
        static void Main(string[] args)
        {
            Operation<decimal, int> op = Square;

            Console.WriteLine(op(5));
            Console.Read();
        }

        static decimal Square(int n)
        {
            return n * n;
        }
    }
}
