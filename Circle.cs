using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_1
{
    //Створюємо клас Circle 
    //похідні від Shape, з полями radiuіs,
    //та перевизначаємо
    //методи з абстрактного класу Shape:
    public class Circle : Shape
    {
        public double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
