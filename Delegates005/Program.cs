using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates005
{
    class Program
    {
        delegate void Message();

        static void Main(string[] args)
        {
            Message mes1 = Hello;
            mes1 += HowAreYou;  
            mes1();
            Message mes = Hello;
            Message mes2 = HowAreYou;
            Message mes3 = mes + mes2;
            mes3(); 

            Console.Read();
        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
    }
}
