using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates010
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.Withdraw(100);
            account.Withdraw(150);
            Console.ReadLine();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
