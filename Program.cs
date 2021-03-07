using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringCalculator sc = new StringCalculator();
            sc.Add("4667,23423,3222");
        }
    }
}
