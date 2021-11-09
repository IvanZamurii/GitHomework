using System;

namespace Lab_5._3
{
    class IdentityMatrix : Matrix
    {
        public IdentityMatrix()
        {

        }
    }
    class UPMatrix : Matrix
    {
        public UPMatrix()
        {
            Inputter();
        }
        public void Inputter()
        {
            Console.WriteLine("Виберіть спосіб розрахунку визначника матриці: ");
            Console.WriteLine("Введіть '1', якщо методом 'трикутника', введіть '2' - якщо методом Сарруса");
            input = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Matrix
    {
        public static int n = 1, OneCount = 0, ZeroCount = 0, StringsCount = 0, input = 0, det1 = 0, det2 = 0, det = 0, number1 = 0, number2 = 0, ZeroCount2 = 0;
        public static int[] matrix = new int[9];
        public static void InputMatrix()
        {
            Console.WriteLine("Введіть поелементно матрицю: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Введіть номер елементу" + n);
                matrix[i] = Convert.ToInt32(Console.ReadLine());
                if (matrix[i] == 0)
                {
                    ZeroCount2++;
                }
                if (n == 1 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 5 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 9 && matrix[i] == 1)
                {
                    OneCount++;
                }
                if (n == 4 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                if (n == 7 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                if (n == 8 && matrix[i] == 0)
                {
                    ZeroCount++;
                }
                n++;
            }
        }
        public static void Input()
        {
            Console.WriteLine("Виберіть спосіб прорахунку визначника матриці: ");
            Console.WriteLine("Введіть '1', якщо методом 'трикутника', введіть '2' - якщо методом Сарруса");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public static void Operation()
        {
            number1 = OneCount;
            number2 = ZeroCount;
            if (number1 == 3 && ZeroCount2 == 6)
            {
                Console.WriteLine("Ви ввели одиничну матрицю");
                number1 = 10;
            }
            if (number2 == 3)
            {
                Console.WriteLine("Ви ввели верхню трикутну матрицю");
                number2 = 10;
            }
            else if (number1 != 3 && number2 != 3)
            {
                if (number1 == 10 || number2 == 10)
                {
                    number1 = 10;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ви ввели стандартну матрицю");
                    Console.WriteLine("");
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                StringsCount++;
                if (StringsCount == 3)
                {
                    Console.Write(" " + matrix[i] + " ");
                    Console.WriteLine("");
                    StringsCount = 0;
                }
                else
                {
                    Console.Write(" " + matrix[i] + " ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix.InputMatrix();
            Matrix.Operation();
            Matrix m = new Matrix();
            if (Matrix.OneCount == 3)
            {
                IdentityMatrix id = new IdentityMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    TriangleMethod1 tm1 = new TriangleMethod1();
                }
                else if (Matrix.input == 2)
                {
                    SarrusRule1 sr1 = new SarrusRule1();
                }
            }
            else if (Matrix.ZeroCount == 3)
            {
                UPMatrix um = new UPMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    TriangleMethod2 tm2 = new TriangleMethod2();
                }
                else if (Matrix.input == 2)
                {
                    SarrusRule2 sr2 = new SarrusRule2();
                }
            }
        }
    }
    class SarrusRule1 : IdentityMatrix
    {
        public SarrusRule1()
        {
            SarrusCount();
        }
        public static void SarrusCount()
        {
            det1 = matrix[0] * matrix[4] * matrix[8] + matrix[1] * matrix[5] * matrix[6] + matrix[2] * matrix[3] * matrix[7];
            det2 = matrix[2] * matrix[4] * matrix[6] + matrix[0] * matrix[5] * matrix[7] + matrix[1] * matrix[3] * matrix[8];
            det = det1 - det2;
            Console.WriteLine("det = " + matrix[0] + "*" + matrix[4] + "*" + matrix[8] + "+" + matrix[1] + "*" + matrix[5] + "*" + matrix[6] + "+" + matrix[2] + "*" + matrix[3] + "*" + matrix[7] + "-");
            Console.WriteLine("-" + matrix[2] + "*" + matrix[4] + "*" + matrix[6] + "-" + matrix[0] + "*" + matrix[5] + "*" + matrix[7] + "-" + matrix[1] + "*" + matrix[3] + "*" + matrix[8]);
            Console.WriteLine("det = " + det);
        }
    }
    class SarrusRule2 : UPMatrix
    {
        public SarrusRule2()
        {
            SarrusRule1.SarrusCount();
        }
    }
    class TriangleMethod1 : IdentityMatrix
    {
        public TriangleMethod1()
        {
            TriangleCount();
        }
        public static void TriangleCount()
        {
            det1 = matrix[0] * matrix[4] * matrix[8] + matrix[2] * matrix[3] * matrix[7] + matrix[1] * matrix[5] * matrix[6];
            det2 = matrix[2] * matrix[4] * matrix[6] + matrix[1] * matrix[3] * matrix[8] + matrix[0] * matrix[5] * matrix[7];
            det = det1 - det2;
            Console.WriteLine("det = " + matrix[0] + "*" + matrix[4] + "*" + matrix[8] + "+" + matrix[2] + "*" + matrix[3] + "*" + matrix[7] + "+" + matrix[1] + "*" + matrix[5] + "*" + matrix[6] + "-");
            Console.WriteLine("-" + matrix[2] + "*" + matrix[4] + "*" + matrix[6] + "-" + matrix[1] + "*" + matrix[3] + "*" + matrix[8] + "-" + matrix[0] + "*" + matrix[5] + "*" + matrix[7]);
            Console.WriteLine("det = " + det);
        }
    }
    class TriangleMethod2 : UPMatrix
    {
        public TriangleMethod2()
        {
            TriangleMethod1.TriangleCount();
        }
    }
}
