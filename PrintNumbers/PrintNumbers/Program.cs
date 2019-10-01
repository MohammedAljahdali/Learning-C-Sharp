using System;

namespace PrintNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sign = 1;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(sign*(2*i-1));
                sign = -sign;
            }
            Console.WriteLine("");
        }
    }
}
