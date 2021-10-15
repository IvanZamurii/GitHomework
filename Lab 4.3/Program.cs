using System;
using System.Diagnostics;

namespace Lab_4._3
{
    class Person
    {
        private static string name;

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Person()
        {
            name = "Ivan";
        }
    }

    class A : Person
    {
        private static string surname;

        public static string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public A()
        {
            surname = "Zamurii";
        }
    }
    class Б : A
    {
        private static int age;
        public static int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Б()
        {
            age = 19;
        }

        static public void Show()
        {
            Trace.WriteLine(Name);
            Trace.WriteLine(Surname);
            Trace.WriteLine(Age);
        }
    }
    class Program
    {
        static public void Main()
        {
            Б b = new Б();
            Б.Show();
        }
    }
}
