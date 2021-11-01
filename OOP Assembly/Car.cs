using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assembly
{
    public class Car
    {
        public string _car1;
        public string _car2;

        public Car(string car1, string car2)
        {
            _car1 = car1;
            _car2 = car2;
        }

        public string Color = "red";

        public string GetColor() => Color;
    }
}
