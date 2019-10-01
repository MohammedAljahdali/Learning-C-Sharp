using System;

namespace ForEach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] x = new int[10];
            for (int i = 0; i < 10; i++)
            {
                x[i] = i;
            }
            foreach(int n in x)
            {
                Console.WriteLine(n);
            }

            
        }
    }
}
