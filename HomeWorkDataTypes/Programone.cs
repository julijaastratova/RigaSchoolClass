using System;

namespace HomeWorkDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal height = 1.65m;
            decimal agePoint = 30.10m;
            int age = 30;
            DateTime date = DateTime.Now;
            string name = "Julija";
            string city = "Riga";
          
            Console.WriteLine("My name is " + name + ", my height is " + height + " cm.");
            Console.WriteLine("I am " + agePoint + " years old, but in fact I am still " + (int)agePoint + ".");
            Console.WriteLine("I am from " + city + ".");
            Console.WriteLine("Today is " + date + ", thank you for your attention!");
            Console.ReadLine();


        }
    }
}
