using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_1
{
    //Створюємо абстрактний клас Shape
    //з полем name та властивістю Name
    //та абстрактними методами Area()
    //та Perimeter():
    public abstract class Shape
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();
    }
}
