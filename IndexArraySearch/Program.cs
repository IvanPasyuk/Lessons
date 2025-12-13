using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] sourceArray = new int[arraySize];
            Random randomElement = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                sourceArray[i] = randomElement.Next(101);
            } 

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(sourceArray[i] + "\t");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Введите элемент, индекс которого необходимо найти в массиве: ");
            int elementToFind = int.Parse(Console.ReadLine());

            bool elementNotFound = true;
            for (int i = 0; i < arraySize; i++)
            {                
                if (elementToFind == sourceArray[i])
                {
                    elementNotFound = false;
                    Console.WriteLine("Индекс элемента в массиве: " + i);
                    break;
                }
            }

            if (elementNotFound)
            {
                Console.WriteLine("Элемент отсутствует в массиве");
            }

            Console.ReadLine();
        }
    }
}
