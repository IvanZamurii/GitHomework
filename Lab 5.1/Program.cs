using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_5._1
{
    class MoveSquare
    {
        public static int x, y, length, RemoveOrRotate;
        public static Rectangle rect = new Rectangle();
        public static Point leftUp = new Point();
        public static Point leftDown = new Point();
        public static Point rightUp = new Point();
        public static Point rightDown = new Point();
        public MoveSquare()
        {
            if (RemoveOrRotate == 1)
            {
                RectangleInfo();
                Console.WriteLine("Натисніть стрілку вправо – щоб пересунути квадрат вправо, або стрілку вліво – щоб пересунути його вліво");
            }
            while (RemoveOrRotate == 1)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    leftUp.X++;
                    leftDown.X++;
                    rightUp.X++;
                    rightDown.X++;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    Move();
                }
            }
        }
        public static void Input()
        {
            Console.WriteLine("Введіть верхній лівий кут квадрата (координати) та його довжину");
            Console.WriteLine("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Довжина: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть '1', якщо хочете пересунути квадрат, введіть '2', якщо хочете його покрутити");
            RemoveOrRotate = Convert.ToInt32(Console.ReadLine());
        }
        private void Move()
        {
            leftUp.X--;
            leftDown.X--;
            rightUp.X--;
            rightDown.X--;
            Display();
        }
        protected void RectangleInfo()
        {
            leftUp.X = x;
            leftUp.Y = y;
            leftDown.X = x;
            leftDown.Y = y - length;
            rightUp.X = x + length;
            rightUp.Y = y;
            rightDown.X = x + length;
            rightDown.Y = y - length;
            rect.X = leftUp.X;
            rect.Y = leftUp.Y;
            rect.Width = length;
            rect.Height = length;
            Display();
            Console.WriteLine("Параметри квадрата: " + rect);
        }
        protected void Display()
        {
            Console.WriteLine("");
            Console.WriteLine("Координати верхнього лівого кута: " + leftUp);
            Console.WriteLine("Координати нижнього лівого кута: " + leftDown);
            Console.WriteLine("Координати верхнього правого кута: " + rightUp);
            Console.WriteLine("Координати нижнього правого кута: " + rightDown);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            MoveSquare.Input();
            MoveSquare m = new MoveSquare();
            RotateSquare rt = new RotateSquare();
        }
    }
    class RotateSquare : MoveSquare
    {
        public static Point p = new Point();
        public RotateSquare()
        {
            if (RemoveOrRotate == 2)
            {
                RectangleInfo();
                Console.WriteLine("Натисніть стрілку вправо - щоб перевернути квадрат вправо, або стрілку вліво - щоб перевернути його вліво");
            }
            while (RemoveOrRotate == 2)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    p = leftUp;
                    leftUp = leftDown;
                    leftDown = rightDown;
                    rightDown = rightUp;
                    rightUp = p;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    p = leftDown;
                    leftDown = leftUp;
                    leftUp = rightUp;
                    rightUp = rightDown;
                    rightDown = p;
                    Display();
                }
            }
        }
    }
}
