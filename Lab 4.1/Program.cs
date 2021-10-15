using System;
using System.Diagnostics;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Outputer.Input();
            Display.Show();
        }
    }
    class Outputer
    {
        public static string input;
        public static void Input()
        {
            Console.WriteLine("Введіть дані: ");
            input = Console.ReadLine();
        }
    }
    class Display : Outputer
    {
        private static bool IsTrue;
        private static bool i;
        private static int number;
        private static char symbol;
        private static double NumberPoint;
        public static void Check()
        {
            IsTrue = int.TryParse(input, out number);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: число");
            }
            IsTrue = char.TryParse(input, out symbol);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: символ");
            }
            IsTrue = bool.TryParse(input, out i);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: bool");
            }
            IsTrue = double.TryParse(input, out NumberPoint);
            if (IsTrue == true)
            {
                Trace.WriteLine("Тип: десяткове число");
            }
            Trace.WriteLine("Тип: рядок");
        }
        public static void Show()
        {
            Trace.WriteLine(input);
            Check();
        }
    }
}
