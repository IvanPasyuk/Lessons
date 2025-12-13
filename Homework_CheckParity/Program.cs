using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_CheckParity
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkingValue;

            Console.WriteLine("Введите целое число: ");
            checkingValue = int.Parse(Console.ReadLine());

            if (checkingValue % 2 == 0)
            {
                Console.WriteLine("Введённое число чётное");
            }
            else
            {
                Console.WriteLine("Введённое число нечетное");
            }

        }
    }
}
