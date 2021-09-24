using System;

namespace Lab_work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дію, яку потрібно виконати:");
            Console.WriteLine("-Введіть 1 для додавання");
            Console.WriteLine("-Введіть 2 для віднімання");
            Console.WriteLine("-Введіть 3 для множення");           
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть перше число");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }               
                default:
                    Console.WriteLine("Неправильна дія! Спробуйте ще раз");
                    break;
            }
            Console.WriteLine("Результат - {0}", result);
            Console.ReadKey();
        }         
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }         
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }         
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }        
    }
}
