using System;

namespace Delegates
{
    class Program
    {

        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        static void Main(string[] args)
        {
            Joiner joiner = new Joiner("Good Morning");

            Action<string> strOP = PrintUpper;

            strOP += PrintLower;
            strOP += joiner.JoinAndPrint;

            strOP.Invoke("Everyone");
        }
    }
}
