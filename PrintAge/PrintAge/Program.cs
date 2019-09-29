using System;

namespace PrintAge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Age: ");
            int age;
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is " + age);
        }
    }
}
