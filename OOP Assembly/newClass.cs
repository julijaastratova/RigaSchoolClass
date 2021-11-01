using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace OOP_Assembly
{
    public class newClass
    {
        private static void Main(string[] args)
        {
            var car = new Car("Rover", "Jaguar");

            Console.WriteLine(car._car1);
            Console.WriteLine(car._car2);

            Console.ReadLine();
        }
    }
}
