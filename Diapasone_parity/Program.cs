using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diapasone_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_value;
            int second_value;

            do
            {
                Console.WriteLine("Введите первое число диапазона: ");
                first_value = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число диапазона: ");
                second_value = int.Parse(Console.ReadLine());

            } while (second_value <= first_value);
            
            int count = first_value;
            int count_pair = 0;
            int count_unpair = 0;
            while (count <= second_value)
            {
                if (count % 2 == 0)
                {
                    count_pair++;
                }
                else
                {
                    count_unpair++;
                }

                count++;                
            }

            Console.WriteLine("Количество четных чисел в введенном диапазоне: {0}", count_pair);
            Console.WriteLine("Количество четных чисел в введенном диапазоне: {0}", count_unpair);
            Console.ReadLine();
        }
    }
}
