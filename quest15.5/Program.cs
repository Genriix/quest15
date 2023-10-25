using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest15._5
{
    static class ArrayExtensions
    {
        public static void SortAscending(this int[] array) { Array.Sort(array); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через пробел:");
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            int[] array = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++) { array[i] = Convert.ToInt32(elements[i]); }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            array.SortAscending();

            Console.WriteLine("Отсортированный массив по возрастанию:");
            PrintArray(array);

            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
