using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_1
{
    //Створюємо клас Square, похідні від Shape,
    //з полями side відповідно, та
    //перевизначаємо методи з абстрактного
    //класу Shape:

    public class Square : Shape
    {
        public double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}
