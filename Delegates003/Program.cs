using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates003
{
    class Math
    {
        public int Sum(int x, int y) { return x + y; }
    }
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Math math = new Math();
            Operation del = math.Sum;
            int result = del(4, 5);    
            Console.WriteLine(result); 

            Console.Read();
        }
    }
}
