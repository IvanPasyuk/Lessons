using System;

namespace Console_Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangle_width = 10;

             for (int i = 0; i < triangle_width; i++)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write("#");
                 }
                 Console.WriteLine(" ");
             }

             Console.WriteLine();

             for (int i = triangle_width; i > 0; i--)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write("#");
                 }
                 Console.WriteLine(" ");
             }

             Console.WriteLine();

            for (int i = 0; i < triangle_width; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                
            }

            Console.WriteLine();

            for (int i = triangle_width; i > 0; i--)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
