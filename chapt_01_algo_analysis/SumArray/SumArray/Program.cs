using System;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int total = SumArray(arr);
            Console.Write($"Sum of values in array: ");
            PrintArray(arr);
            Console.Write($" is {total}");
        }

        static void PrintArray(int[] arr) {

            int size = arr.Length;
            if (size <= 0)
                throw new Exception("Empty Array!");

            Console.Write("{");
            for (int i = 0; i < size - 1; i++)
                Console.Write($"{arr[i]}, ");
            Console.Write($"{arr[size - 1]}");
            Console.Write("}");
        }

        static int SumArray(int[] arr) {

            int size = arr.Length;
            int total = 0;

            for (int i = 0; i < size; i++) {
                total += arr[i];
            }
            return total;
        }
    }
}
