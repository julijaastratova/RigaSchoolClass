using System;

namespace ClassworkAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("cat", "meow");

            Console.WriteLine($"{animal._animal} says {animal._says}");

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
