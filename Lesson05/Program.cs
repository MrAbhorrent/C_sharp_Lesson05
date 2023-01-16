using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson05
{
    class Program
    {
        private static int[] array1;
        private static String divider = "============================================================================";

        private static int[] CreateArray( int _size )
        {
            int multiplyBy = 100;
            Random rnd = new Random();
            int[] array = new int[_size];
            int random;
            for (int i = 0; i < _size; i++)
            {
                random = rnd.Next(100, 1000);
                array[i] = random;
            }            
            return array;
        }

        private static void PrintArray(int[] _array)
        {
            if (_array.Length > 0)
            {
                Console.Write("[");
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.Write("{0}", _array[i]);
                    if (i == _array.Length - 1)
                    {
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
        }

        private static int CountEvenNumberInArray( int[] _array )
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0) count++;
            }
            return count;
        }

        static void Main( string[] args )
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            //    [345, 897, 568, 234] -> 2
            Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
            Console.Write("Введите длинну массива - ");
            int size = Convert.ToInt32(Console.ReadLine());            
            array1 = CreateArray(size);
            PrintArray(array1);
            Console.WriteLine("\t-> {0}", CountEvenNumberInArray(array1));
            Console.WriteLine(divider);
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            //    [3, 7, 23, 12] -> 19
            //    [-4, -6, 89, 6] -> 0
            Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
            Console.WriteLine(divider);        
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //    [3 7 22 2 78] -> 76
            Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            Console.WriteLine(divider);

            Console.ReadKey();
        }
    }
}
