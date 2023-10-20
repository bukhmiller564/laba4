using System;

namespace ConsoleApp1
{
    class Program
    {
        //функция
        public static double F(double x)
        {
            return Math.Sin(1 - 0.2 * Math.Pow(x, 2)) - x;  //Вычисление функции
        }
        public static double Trap(double a, double b, double S, double h) //Вычисление Площади трапеции
        {
            int count = 1;
            for (double i = a; i < b; i += h)
            {
                S += (F(i) + F(i + h)) / 2;
                Console.WriteLine("Площадь {0} трапеции = {1}", count, (F(i) + F(i + h)) / 2);
                count++;
            }
            return (S);
        }

        static void Main(string[] args)
        {
            // Ввод данных
            double S = 0, S1 = 0;
            Console.Write("Введите первый предел = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введите второй предел  =");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Введите количество частичных интервалов = ");
            double n = Double.Parse(Console.ReadLine());
            double n1 = n;
            Console.Write("Введите точность = ");
            double eps = Double.Parse(Console.ReadLine());
            double c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }
            do
            {
                double h = (b - a) / n;
                S = Trap(a, b, S, h) * h;
                S1 = S;
                n = n * 2;
            }
            while (Math.Abs(S1 - S) >= eps);
            // Вывод данных
            Console.WriteLine("Cумма площадей трапеций на отрезке[{0};{1}] равно S = {2}", a, b, S);
        }
    }
}

