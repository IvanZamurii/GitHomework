using System;

namespace Лабораторна_робота_2
{
    class Program
    {
        class Converter
        {

            double hrn;
            public void SetHrn(double value)
            {
                hrn = value;
            }
            public double GetHrn()
            {
                return hrn;
            }
            double usd;
            public double GetUsd()
            {
                return usd;
            }
            double eur;
            public double GetEur()
            {
                return eur;
            }          
            public double nUsd;
            public void SetNUsd(double value)
            {
                nUsd = value;
            }
            public double GetNUsd()
            {
                return nUsd;
            }
            public double MethodUsd(double usd, double hrn, double nUsd)
            {
                nUsd = usd * hrn;
                return nUsd;
            }
            public double MethodEur(double eur, double hrn, double nEur)
            {
                nEur = eur * hrn;
                return nEur;
            }           
           public Converter(double usd, double eur)
            {
                this.usd = usd;
                this.eur = eur;                
                Console.Write("Введiть к-сть іноземної валюти:");
                this.hrn = Convert.ToDouble(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            Converter money = new Converter(26.63, 31.25);
            Console.WriteLine("Курси валют: ");
            Console.WriteLine("Курс долару - {0}, \nКурс евро - {1}", money.GetUsd(), money.GetEur());
            Console.WriteLine("Результат:");
            money.MethodUsd(26.63, money.GetHrn(), 1);
            Console.WriteLine("Долар - {0}", money.MethodUsd(26.63, money.GetHrn(), 1));
            money.MethodEur(31.25, money.GetHrn(), 1);
            Console.WriteLine("Евро - {0}", money.MethodEur(31.25, money.GetHrn(), 1));                      
            Console.ReadKey();
        }
    }
}
