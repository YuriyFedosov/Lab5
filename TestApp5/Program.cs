using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1*/

            Console.WriteLine("Программа вывода массива с маской заполнения типа 1 0 1 0 1 0..");
            Console.Write("Введите размерность массива N, для создания двумерного массива NxN: ");
            int numbForArray = Convert.ToInt32(Console.ReadLine());  // Ввод Размерности массива (Элементы по горизонтали и вертикали равны)

            int[,] array = new int[numbForArray, numbForArray];
            bool flag = true;  // Флаг для инверсии статуса заполнения ячейки массива
           
            for (int i = 0; i < numbForArray; i++) //
            {
                for (int j = 0; j < numbForArray; j++)
                {
                    if (!flag)
                    {
                        array[i,j] = 0;
                        flag = true;
                        Console.Write("{0} ",array[i, j]);
                    }
                    else
                    {
                        array[i, j] = 1;
                        flag = false;
                        Console.Write("{0} ", array[i, j]);

                    }
                  
                }
           
                Console.WriteLine();
            }
           
            Console.WriteLine("Нажмите любую клавишу для выхода ...");

            Console.ReadKey();
        }
    }
}
