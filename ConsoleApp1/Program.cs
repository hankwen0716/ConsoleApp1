using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15, tax = 8;
            int total = tip_percent + tax + Convert.ToInt32(meal_cost);
            Console.WriteLine("餐費一共是"+total);
            Console.ReadLine();
        }
    }
}
