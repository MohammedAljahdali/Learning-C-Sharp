using System;


namespace DateAndTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToString("yy/MMM/dd hh:mm"));
        }
    }
}
