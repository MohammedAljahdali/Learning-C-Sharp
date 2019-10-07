using System;

namespace SortReverseAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            
            switch (choice) {
                case 0:
                    Console.WriteLine("first case");
                    break;
            }
            Console.WriteLine("Hello World!");
            int[] array = { 22, 4, 5, 6, 0, 24, 23, 7, 1, 29 };
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            array = sort(array);
            Console.WriteLine("");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }

        }
        public static int[] sort(int[] array)
        {
            int holder = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
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
