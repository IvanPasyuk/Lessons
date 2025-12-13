using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Привет, мир!");
            Console.WriteLine("Задание 1.");
            int a, b;
            Console.WriteLine("Введите число 1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            double result = (double)(a + b) / 2;

            Console.WriteLine("\nСреднее арифметическое двух введенных чисел: " + result);

            Console.WriteLine("\nЗадание 2.");
            Console.WriteLine("Введите число 1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            int c;
            Console.WriteLine("Введите число 3: ");
            c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;
            int product = a * b * c;

            Console.WriteLine("Сумма введенных чисел: " + sum);
            Console.WriteLine("Произведение введенных чисел: " + product);

            Console.WriteLine("\nЗадание 3.");

            double course = 73.64;
            Console.WriteLine("Введите сумму в рублях: ");
            double value = Convert.ToDouble(Console.ReadLine());

            result = value / course;
            Console.WriteLine("Сумма в долларах: " + result);


        }
    }
}
