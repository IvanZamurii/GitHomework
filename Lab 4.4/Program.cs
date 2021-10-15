using System;

namespace Lab_4._4
{
    class ApplicationLicense
    {
        private static void AllowTrial()
        {
            Console.WriteLine("Trial режим");
        }
        private static void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }
        private static void AllowPro()
        {
            Console.WriteLine("Платна версія");
        }
        public ApplicationLicense(string Key)
        {
            if (Key == "431")
            {
                AllowTrial();
            }
            else if (Key == "785")
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть ключ доступу (431 - Trial версія, 785 - Повна версія)");
            Console.WriteLine("Якщо ключ не введений, або введений невірно, користувач отримає доступ до безкоштовної версії");
            string Key = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense(Key);
        }
    }
}
