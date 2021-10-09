using System;
namespace restless
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, h;
            Console.Write("R=");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("h=");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Объём цилиндра: {3.14 * R * R * h}");
            Console.WriteLine($"Объём конуса: {(3.14 * R * R * h) * 1 / 3}");
        }
    }
}

