using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_5._2
{
    class Cone
    {
        public static Point point = new Point();
        public static double S, V, h, r, R, PI = 3.14;
        public static int input = 0;
        public Cone()
        {
            if (input == 1)
            {
                SquareCone();
                VCone();
            }
        }
        private void SquareCone()
        {
            S = PI * point.X * point.X;
            Console.WriteLine("Площа: " + S);
        }
        private void VCone()
        {
            V = S * point.Y / 3;
            Console.WriteLine("Об'єм: " + V);
        }
        public static void Input()
        {
            Console.WriteLine("Введіть радіус основи конуса: ");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть висоту конуса: ");
            point.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Радіус конуса: " + point.X);
            Console.WriteLine("Висота конуса: " + point.Y);
        }
    }
    class Conoid : Cone
    {
        public Conoid()
        {
            VConoid();
        }
        private void VConoid()
        {
            V = PI * h * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2) / 3);
            Console.WriteLine("Об'єм зрізаного конуса: " + V);
        }
        public static void Input1()
        {
            Console.WriteLine("Введіть висоту конуса: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть радіус більшої основи конуса: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть радіус меншої основи конуса: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Висота конуса: " + h);
            Console.WriteLine("Радіус більшої основи: " + R);
            Console.WriteLine("Радіус меншої основи: " + r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть '1' для розрахунку звичайного конуса, і '2' - для усіченого");
            Cone.input = Convert.ToInt32(Console.ReadLine());
            if (Cone.input == 1)
            {
                Cone.Input();
                Cone cone = new Cone();
            }
            else if (Cone.input == 2)
            {
                Conoid.Input1();
                Conoid conoid = new Conoid();
            }
        }
    }
}
