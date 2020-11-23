using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string
            string name = "shiva";
            Console.WriteLine(name);//output : shiva

            name = "\"shiva\"";
            Console.WriteLine(name);//output : "shiva" - this is called escape sequences

            name = "One\nTwo\nThree";
            Console.WriteLine(name);//output : One
            //                                 Two
            //                                 Three
        }
    }
}
