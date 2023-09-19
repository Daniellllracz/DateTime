using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //eltel idő
            TimeSpan ts01 = new TimeSpan(06,30,22);
            TimeSpan ts02 = new TimeSpan(06,30,22);
            double td = ts01.TotalDays;

            //datum idő
            DateTime dt01 = new DateTime(2004, 11,12);

            Console.WriteLine(dt01.ToString("yyyy-MM-dd (dddd)"));


            Console.ReadKey(true);
        } 
    }
}
