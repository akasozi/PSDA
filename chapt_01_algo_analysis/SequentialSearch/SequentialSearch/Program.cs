using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
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
