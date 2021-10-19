using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
             * Определить сумму максимального и минимального элементов массива.*/

            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++) //Заполнение массива
            {
                array[i] = random.Next(0,50);
                Console.WriteLine(array[i]);
            }
            int maxValue = array[0]; // Инициализация переменных для хранения мин/макс значений
            int minValue = array[0];
            foreach (var a in array)  //Поиск мин/макс значений
            {
                if (a > maxValue)
                    maxValue = a;
            }
            foreach (var a in array)
            {
                if (a < minValue)
                    minValue = a;
            }

            Console.Write("Сумма минимального и максимального значения: ");
            Console.WriteLine(minValue+maxValue);
            Console.ReadKey();
        }
    }
}
