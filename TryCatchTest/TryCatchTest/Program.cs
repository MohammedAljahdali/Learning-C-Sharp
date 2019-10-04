using System;

namespace TryCatchTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter two numbers to divide: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondtNumber = int.Parse(Console.ReadLine());
            try
            {
                int output = firstNumber / secondtNumber;
                Console.WriteLine("The out put is: " + output);
            } catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
    }
}
