using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = hello();
            Console.WriteLine(h);
            Console.ReadLine();
        }

        static int hello()
        {
            Console.WriteLine("Skriv nagot");
            string s = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine(s);
            return 4;
        }
    }
}
