using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 0;
            i = null;
            int a = i ?? 10;
            Console.WriteLine(a);


            
        }
    }
}
