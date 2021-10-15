using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Б1 example1 = new Б1();
            Б2 example2 = new Б2();
            Б3 example3 = new Б3();
            string information;
            information = Б1.argument1;
            A A1 = new A(information);
            A.Display();
            information = Б2.argument2;
            A A2 = new A(information);
            A.Display();
            information = Б3.argument3;
            A A3 = new A(information);
            A.Display();
        }
    }

    public class Б
    {
        protected static string argument;
        public static void Show()
        {
            Console.WriteLine("Введите аргумент: ");
            argument = Console.ReadLine();
        }
    }

    public class Б1 : Б
    {
        public static string argument1;
        public Б1()
        {
            Show();
            argument1 = argument;
        }
    }

    public class Б2 : Б
    {
        public static string argument2;
        public Б2()
        {
            Show();
            argument2 = argument;
        }
    }

    public class Б3 : Б
    {
        public static string argument3;
        public Б3()
        {
            Show();
            argument3 = argument;
        }
    }

    class A
    {
        public A(string information)
        {
            Input = information;
        }
        public static int number, count = 0;
        public static char symbol;
        public static bool TrueOrFalse, IsTrue;
        public static double PointNumber;
        public static string str;
        private static string input;
        public static string Input
        {
            get
            {
                return input;
            }
            set
            {
                str = value;
                IsTrue = int.TryParse(str, out number);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: число";
                }
                IsTrue = double.TryParse(str, out PointNumber);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: десяткове число";
                }
                IsTrue = char.TryParse(str, out symbol);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: символ";
                }
                IsTrue = bool.TryParse(str, out TrueOrFalse);
                if (IsTrue == true)
                {
                    value = value + " " + "Тип: булеан";
                }
                if (count == 0)
                {
                    value = value + " " + "Тип: стрічка";
                }
                input = "Значення: " + value + "Модифікатор доступу: public";
            }
        }
        public static void Display()
        {
            Trace.WriteLine(input);
        }
    }



}
