using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            Console.WriteLine("Введите первое число: ");
            firstValue = double.Parse(Console.ReadLine());

            //string valueInput = Console.ReadLine();
            //bool resultInputValue = int.TryParse(valueInput, out firstValue);

            //if (resultInputValue == false)
            //    Console.WriteLine("Вы ввели некорректные данные");

            Console.WriteLine("Введите действие (+, -, *, /): ");
            ConsoleKey action = Console.ReadKey().Key;

            Console.WriteLine("\nВведите второе число: ");
            secondValue = double.Parse(Console.ReadLine());
            //string secondValueInput = Console.ReadLine();
            //bool secondResultInputValue = int.TryParse(secondValueInput, out secondValue);

            //if (secondResultInputValue == false)
            //    Console.WriteLine("Вы ввели некорректные данные");

            //int result;

            switch (action)
            {
                case ConsoleKey.OemPlus:
                    {
                        Console.WriteLine("Сумма введенных чисел: {0}", firstValue + secondValue);
                        //Console.WriteLine(firstValue + secondValue);
                        Console.ReadLine();
                    }
                    break;
                case ConsoleKey.OemMinus:
                    {
                        Console.WriteLine("Разность введенных чисел: {0}", firstValue - secondValue);
                        Console.ReadLine();
                    }
                    break;
                case ConsoleKey.Multiply:
                    {
                        Console.WriteLine("Произведение введенных чисел: {0}", firstValue * secondValue);
                        Console.ReadLine();
                    }
                    break;
                case ConsoleKey.Divide:
                    {
                        Console.WriteLine("Результат сумму введенных чисел: {0}", firstValue / secondValue);
                        Console.ReadLine();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Введено некорректное действие");
                        Console.ReadLine();
                    }
                    break;
            }

        }
    }
}
