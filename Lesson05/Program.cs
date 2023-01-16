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

        private static int[] CreateRandomArray( int _size )
        {
            Random rnd = new Random();
            int[] array = new int[_size];
            int random;
            for (int i = 0; i < _size; i++)
            {
                random = rnd.Next();
                array[i] = random;
            }
            return array;
        }

        private static int[] CreateRandomArray( int _size, int _maxValue )
        {            
            Random rnd = new Random();
            int[] array = new int[_size];
            int random;
            for (int i = 0; i < _size; i++)
            {
                random = rnd.Next(_maxValue);
                array[i] = random;
            }            
            return array;
        }

        private static int[] CreateRandomArray( int _size, int _minValue, int _maxValue )
        {            
            Random rnd = new Random();
            int[] array = new int[_size];
            int random;
            for (int i = 0; i < _size; i++)
            {
                random = rnd.Next(_minValue, _maxValue);
                array[i] = random;
            }
            return array;
        }

        private static double[] CreateRandomArray( int _size, double _minValue, double _maxValue )
        {
            Random rnd = new Random();
            double[] array = new double[_size];            
            for (int i = 0; i < _size; i++)
            {                
                array[i] = rnd.Next((int)_minValue, (int)_maxValue - 1) + rnd.NextDouble();
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

        private static void PrintArray( double[] _array )
        {
            
            if (_array.Length > 0)
            {
                ConsoleColor color = Console.ForegroundColor;
                
                Console.Write("[");
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0:F2}", _array[i]);
                    Console.ForegroundColor = color;
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

        private static int SumOddNumbersInAray( int[] _array )
        {
            int sum = 0;
            for (int i = 0; i < _array.Length; i += 2)
            {
                sum += _array[i];
            }
            return sum;
        }

        private static double FindMinValue( double[] _array )
        {
            double min = 0.0;
            if (_array.Length > 0)
            {
                min = _array[0];
                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i] < min) min = _array[i];
                }
            }
            return min;
        }

        private static double FindMaxValue( double[] _array )
        {
            double max = 0.0;
            if (_array.Length > 0)
            {
                max = _array[0];
                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i] > max) max = _array[i];
                }
            }
            return max;
        }

        static void Main( string[] args )
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            //    [345, 897, 568, 234] -> 2
            Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
            Console.Write("Введите длинну массива - ");
            int size = Convert.ToInt32(Console.ReadLine());
            array1 = CreateRandomArray(_size: size, _minValue: 100, _maxValue: 1000);
            PrintArray(array1);
            Console.WriteLine("\t-> {0}", CountEvenNumberInArray(array1));
            Console.WriteLine(divider);

            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            //    [3, 7, 23, 12] -> 19
            //    [-4, -6, 89, 6] -> 0
            Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
            Console.Write("Введите длинну массива - ");            
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = CreateRandomArray(_size: size2, _maxValue: 100);
            PrintArray(array2);
            Console.WriteLine("\t-> {0}", SumOddNumbersInAray(array2));
            Console.WriteLine(divider);
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //    [3 7 22 2 78] -> 76
            Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            Console.Write("Введите длинну массива - ");
            int size3 = Convert.ToInt32(Console.ReadLine());
            double[] array3 = CreateRandomArray(_size: size3, _minValue: -100.0, _maxValue: 100.0);
            PrintArray(array3);
            Console.WriteLine("\t -> {0:F2}", (double)(FindMaxValue(array3) - FindMinValue(array3)));
            Console.WriteLine(divider);

            Console.ReadKey();
        }
    }
}
