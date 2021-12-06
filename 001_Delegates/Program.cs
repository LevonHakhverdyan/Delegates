using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Delegates
{
    public delegate void MyDelegate();
    public delegate string MyDelegate1(string name);
    public delegate int MyDelegate2(int a, int b);
    public delegate void MyDelegate3(ref int a1, ref int b1, out int c);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke();
            myDelegate();
            Console.WriteLine(new string('-', 20));
            MyClass1 instance = new MyClass1();
            MyDelegate myDelegate1 = new MyDelegate(instance.Method);
            myDelegate1();

            Console.WriteLine(new string('-', 20));
            MyClass2 instance1 = new MyClass2();
            MyDelegate1 myDelegate2 = new MyDelegate1(instance1.Method);
            Console.WriteLine(instance1.Method(" Levon"));

            Console.WriteLine(new string('-', 20));
            MyDelegate delegate1 = null;
            MyDelegate delegate2 = new MyDelegate(MyClass3.Method1);
            MyDelegate delegate3 = new MyDelegate(MyClass3.Method2);
            MyDelegate delegate4 = new MyDelegate(MyClass3.Method3);
            delegate1 = delegate2 + delegate3 + delegate4;
            Console.WriteLine("Enter a number from 1 to 7");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        delegate2();
                        break;
                    }
                case "2":
                    {
                        delegate3();
                        break;
                    }
                case "3":
                    {
                        delegate4();
                        break;
                    }
                case "4":
                    {
                        MyDelegate delegate5 = delegate1 - delegate2;
                        delegate5();
                        break;
                    }
                case "5":
                    {
                        MyDelegate delegate6 = delegate1 - delegate3;
                        delegate6();
                        break;
                    }
                case "6":
                    {
                        MyDelegate delegate7 = delegate1 - delegate4;
                        delegate7();
                        break;
                    }
                case "7":
                    {
                        delegate1();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered an unavailable number");
                        break;
                    }
            }

            Console.WriteLine(new string('-', 20));
            MyDelegate myDelegate3 = /*new MyDelegate (*/delegate { Console.WriteLine("Hello world"); }/*)*/;
            myDelegate3();

            Console.WriteLine(new string('-', 20));
            int sumand1 = 5;
            int sumand2 = 34;
            int sum = 0;
            MyDelegate2 myDellegate4 = delegate (int a, int b) { return a + b; };
            sum = myDellegate4(sumand1, sumand2);
            Console.WriteLine(sum);

            Console.WriteLine(new string('-', 20));
            int sumand3 = 1;
            int sumand4 = 2;
            int sum1 = 0;
            MyDelegate3 myDelegate5 = delegate (ref int a1, ref int b1, out int c) { a1++; b1++; c = a1 + b1; };
            myDelegate5(ref sumand3, ref sumand4, out sum1);
            Console.WriteLine("{0} + {1} = {2}", sumand3, sumand4, sum1);
            Console.ReadLine();
        }
    }
}
