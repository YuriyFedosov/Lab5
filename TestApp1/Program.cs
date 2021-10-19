using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/

            int[] array = new int[7];
            float sumArray = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Введите {0} значение: ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach(int a in array)
            {
                sumArray += a;
            }
            Console.Write("Cреднее арифметическое значение введенных чисел: {0:f2}", sumArray/7);
            Console.ReadKey();
        }
    }
}
