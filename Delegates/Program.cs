using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Message();

        static void Main(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            mes();
            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
