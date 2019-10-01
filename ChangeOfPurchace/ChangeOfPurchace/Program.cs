using System;

namespace ChangeOfPurchace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(256%100);
            Console.WriteLine("how much did you pay");
            int paid = int.Parse(Console.ReadLine());
            Console.WriteLine("how much is the cost");
            int cost = int.Parse(Console.ReadLine());
            int dif = paid - cost;
            int[] money = { 500, 100, 50, 10, 5, 1 };
            int index = 0;
            for(int i = 0;i < money.Length; i++)
            {
                if (dif >= money[i])
                {
                    index = i;
                    break;
                }
            }
            Console.Write("your change is: "+dif+":");
            do
            {
                Console.Write(money[index]+" ");
                dif = dif - money[index];
                for (int i = 0; i < money.Length; i++)
                {
                    if (dif >= money[i])
                    {
                        index = i;
                        break;
                    }
                }

            } while (dif != 0);

        }
    }
}
