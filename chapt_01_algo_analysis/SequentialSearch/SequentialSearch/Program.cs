using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int elem = 5;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = SequentialSearch(arr, arr.Length, elem);
            Console.WriteLine($"The element: {elem} was found in the index: {index}");
        }

        static int SequentialSearch(int[] arr, int size, int value) {

            for (int i = 0; i < size; i++) {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }
    }
}
