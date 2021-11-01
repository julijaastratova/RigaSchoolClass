using System;

namespace Classwork_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal()
            {
                Age = "5",
                EyeColor = "blue",
                Height = "50 cm"
            };

            Animal animal2 = new Animal("green", "9", "85 cm");

            Console.WriteLine($"Animal 1 age is: {animal1.Age}");
            Console.WriteLine($"Animal 1 eye color is: {animal1.EyeColor}");
            Console.WriteLine($"Animal 1 height is: {animal1.Height}");
            Console.WriteLine($"Animal 2 age is: {animal2.Age}");
            Console.WriteLine($"Animal 2 eye color is: {animal2.EyeColor}");
            Console.WriteLine($"Animal 2 height is: {animal2.Height}");
            Console.WriteLine("After the changes:");
            animal1.ChangeHeight("120 cm");
            animal1.SetAge("55");
            animal2.ChangeHeight("2.5 m");
            animal2.SetAge("43");
            Console.WriteLine($"Animal 1 age is: {animal1.Age}");
            Console.WriteLine($"Animal 1 eye color is: {animal1.EyeColor}");
            Console.WriteLine($"Animal 1 height is: {animal1.Height}");
            Console.WriteLine($"Animal 2 age is: {animal2.Age}");
            Console.WriteLine($"Animal 2 eye color is: {animal2.EyeColor}");
            Console.WriteLine($"Animal 2 height is: {animal2.Height}");



            Console.ReadLine();

            //var animal = new Animal();

            //Console.WriteLine(animal.eyeColor);
            //Console.WriteLine(animal.skinColor);
            //Console.WriteLine(animal.weight);
            //Console.WriteLine(animal.height);
            //Console.WriteLine(animal.age);
            //animal.ChangeHeight("120 cm");
            //Console.WriteLine(animal.height);
            //animal.ChangeSkinColor("blue");
            //Console.WriteLine(animal.skinColor);
            //animal.SetAge("90 years");
            //Console.WriteLine(animal.age);
            //Console.ReadLine();
        }
    }
}
