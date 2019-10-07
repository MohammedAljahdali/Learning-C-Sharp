using System;

namespace SortReverseAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter your array: ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }
            while (choice != 4)
            {
                Console.Write("Enter 1. To sort the array.\nEnter 2. To reverse the array.\nEnter 3. to print the array\nEnter 4. to exit.\nYour input: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        array = sort(array);
                        break;
                    case 2:
                        array = reverse(array);
                        break;
                    case 3:
                        printArray(array);
                        break;
                    case 4:
                        break;
                }
            }
            //Console.WriteLine("Hello World!");
            //int[] array = { 22, 4, 5, 6, 0, 24, 23, 7, 1, 29 };
            
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]+" ");
            //}
            //array = sort(array);
            //Console.WriteLine("");
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]+ " ");
            //}
            //array = reverse(array);
            //Console.WriteLine("");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

        }

        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("");
        }

        public static int[] reverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArray[i] = array[j];
            }
            return newArray;
        }
        public static int[] sort(int[] array)
        {
            int holder = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                holder = array[i];
                array[i] = array[minIndex];
                array[minIndex] = holder;
            }
            return array;
        }
    }  
}
