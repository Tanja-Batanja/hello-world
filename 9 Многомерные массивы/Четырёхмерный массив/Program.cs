using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырёхмерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,,,] myArray = new int[3, 2, 3, 8];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            myArray[i, j, k, q] = random.Next(10, 50);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("==Book № " + (i + 1) + "==");

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Page № " + (j + 1));

                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            Console.Write(myArray[i, j, k, q] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
