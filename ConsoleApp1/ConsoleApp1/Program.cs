using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string username = Console.ReadLine();

            //using concatenation
            Console.WriteLine("Hello " + username);

            //using placeholder
            Console.WriteLine("Hello {0}", username);


        }
    }
}
