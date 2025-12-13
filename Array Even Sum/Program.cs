using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int arrayCount = int.Parse(Console.ReadLine());

            int[] userArray = new int[arrayCount];
            int sumEvenArrayElements = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                int arrayNumber = i + 1;
                Console.WriteLine("Введите {0}й элемент массива: ", arrayNumber);
                userArray[i] = int.Parse(Console.ReadLine());

                if (userArray[i] % 2 == 0)
                {
                    sumEvenArrayElements += userArray[i];
                }
            }

            Console.WriteLine("\nСумма чётных чисел в массиве: ");
            Console.WriteLine(sumEvenArrayElements);

            Console.ReadLine();
        }
    }
}
