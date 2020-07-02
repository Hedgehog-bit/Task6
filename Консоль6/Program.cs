using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент массива: ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += mas[i];
            }
            if ((sum > 9) && (sum < 100))
            {
                Console.WriteLine("Сумма является двузначным числом");
            }
            else Console.WriteLine("Сумма НЕ является двузначным числом");

            Console.WriteLine("Введите размерность массива:");
            Console.Write("Столбцов ");
            int column = int.Parse(Console.ReadLine());
            Console.Write("Строк ");
            int line = int.Parse(Console.ReadLine());
            int[,] dmas = new int[column, line];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    Console.Write("Введите " + (i + 1) + " Столбец " + (j + 1) + " Строка: ");
                    dmas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            sum = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    sum += dmas[i, j];
                }
            }
            if ((sum > 9) && (sum < 100))
            {
                Console.WriteLine("Сумма является двузначным числом");
            }
            else Console.WriteLine("Сумма НЕ является двузначным числом");

            Console.Write("Введите размерность массива: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] mas2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент массива: ");
                mas2[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 1; i < n2; i++)
            {
                if (mas2[i] > mas2[i - 1])
                {
                    counter++;
                }
            }
            Console.WriteLine("Кол-во элементов, значения которых больше значения предыдущего элемента = " + counter);

            Console.WriteLine("Введите размерность массива:");
            Console.Write("Столбцов ");
            int column3 = int.Parse(Console.ReadLine());
            Console.Write("Строк ");
            int line3 = int.Parse(Console.ReadLine());
            int[,] dmas3 = new int[column3, line3];
            for (int i = 0; i < column3; i++)
            {
                for (int j = 0; j < line3; j++)
                {
                    Console.Write("Введите " + (i + 1) + " Столбец " + (j + 1) + " Строка: ");
                    dmas3[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < column3; i++)
            {
                for (int j = 0; j < line3; j++)
                {
                    if (dmas3[i, j] < 0)
                    {
                        counter = 0;
                        for (int a = 0; a < column3; a++)
                        {
                            if (dmas3[a, j] < 0)
                            {
                                counter++;
                            }
                            if (counter == column3)
                            {
                                Console.WriteLine("Столбец состоит из отрицательных значений");
                            }
                        }
                    }
                    if (counter == column3)
                        break;
                }
                if (counter == column3)
                    break;
                else
                {
                    Console.WriteLine("Нет столбца с отрицательными значениями");
                    break;
                }
            }

            Console.Write("Введите размерность массива:");
            int column4 = int.Parse(Console.ReadLine());
            int[][] dmas4 = new int[column4][];
            for (int i = 0; i < column4; ++i)
            {
                dmas4[i] = new int[column4];
                for (int j = 0; j < column4; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    dmas4[i][j] = int.Parse(Console.ReadLine());
                }
            }
            int[] array = new int[column4];
            for (int i = 0; i < column4; i++)
            {
                array[i] = 1;
            }
            for (int i = 0; i < column4; ++i)
            {
                for (int j = 0; j < column4; ++j)
                {
                    array[i] *= dmas4[j][i];
                }
            }
            int min = array[0];
            for (int i = 1; i < column4; i++)
            {
                if (min > array[i]) 
                {
                    min = array[i];
                }
            }
            Console.Write("Минимальный элемент: " + min);
            Console.ReadKey();
        }
    }
}
