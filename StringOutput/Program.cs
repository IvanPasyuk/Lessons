using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOutput
{
    class Program
    {
        static int InputOutputCount()
        {
            int inputTime = 1;

            Console.WriteLine("Введите число выводов введенных символов: ");
            inputTime = int.Parse(Console.ReadLine());

            if (inputTime < 1) 
                inputTime = 1;
            return inputTime;
        }

        static string InputSymbols()
        {
            Console.WriteLine("Введите символы: ");
            string output = Console.ReadLine();
            return output;
        }

        static void Main(string[] args)
        {
            string result = InputSymbols();
            int outputCount = InputOutputCount();

            Console.WriteLine("\nСтрока результат: ");
            for (int i = 0; i < outputCount; i++)
            {
                Console.Write(result);
            }

            Console.ReadLine();
        }

        
    }
}
