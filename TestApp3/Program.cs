using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
             * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. */
            
            int[] array = new int[10]; //Инициализация массива
            Random random = new Random();

            for (int i = 0; i < 10; i++) //Присваивание случайных значений
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ",array[i]);
            }

            for (int i = 0; i < 5; i++) //Сортировка с начала, до 5 элемента
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    
                    
                }
            }
            for (int i = 9; i >= 5; i--) //Сортировка с конца до 5 элемента
            {
                for (int j = i - 1; j >= 5; j--)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }


                }
            }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
              
                Console.Write("{0} ",array[i]); //Вывод результатов
            }
            
            Console.ReadKey();
        }
    }
}
