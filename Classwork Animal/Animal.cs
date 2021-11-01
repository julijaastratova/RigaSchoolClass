using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_Animal
{
    class Animal
    {
        private string eyeColor;
        private string skinColor;
        private string weight;
        private string height;
        private string age;

        public Animal(string eyeColor, string age, string height)
        {
            this.eyeColor = eyeColor;
            this.age = age;
            this.height = height;
        }

        public Animal()
        {

        }

        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }

        public string SkinColor
        {
            get { return skinColor; }
            set { skinColor = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public void ChangeSkinColor(string skinColor)
        {
            SkinColor = skinColor;
        }

        public void ChangeHeight(string height)
        {
            Height = height;
        }

        public void SetAge(string age)
        {
            Age = age;
        }
    }
}
