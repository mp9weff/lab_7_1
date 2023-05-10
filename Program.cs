using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab_7_1
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using Project7_Pysachuk;

    namespace Project7_Pysachuk
    {
        class Program
        { 
                static void Main(string[] args)
                {
                    List<Shape> list = new List<Shape>();
                    string writePath = @"12.txt";
               // створила список фігур та заповнила його 6 різними фігурами(коло та квадрат);

                for (int i = 0; i < 6; i++)
                    {
                        Console.Write("Enter shape name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter 'C' for circle, 'S' for square: ");
                        char choice = Console.ReadLine().ToLower()[0];

                        if (choice == 'c')
                        {
                            Console.Write("Enter radius: ");
                            double radius = double.Parse(Console.ReadLine());
                            Circle c = new Circle(name, radius);
                            list.Add(c);
                        }
                        else if (choice == 's')
                        {
                            Console.Write("Enter side length: ");
                            double side = double.Parse(Console.ReadLine());
                            Square s = new Square(name, side);
                            list.Add(s);
                        }
                    }
                //знайшли і записали у файл фігури з площею в проміжку [10; 100]
                IEnumerable<Shape> AreaBetweenValues = list.Where(Shape => (Shape.Area() >= 10) && (Shape.Area() <= 100));

                    using (StreamWriter sw = new StreamWriter(writePath, false))
                    {
                    sw.WriteLine("shapes with area in range 10-100:");
                        foreach (Shape area in AreaBetweenValues)
                        {

                            sw.WriteLine(area.name + ", area:" + area.Area());

                        }
                    // файл фігури, назва яких містить букву «а»;
                    sw.WriteLine("shapes with 'a' in its name:");
                        foreach (Shape shape in list)
                        {
                            string name = shape.name;

                            Regex regex = new Regex(@"a");
                            MatchCollection matches = regex.Matches(name);

                            if (matches.Count > 0)
                            {

                                sw.WriteLine(name);
                            }

                        }
                    };
                //видалили зі списку всі фігури з периметром менше 5. 
                list.RemoveAll(shape => shape.Perimeter() < 5);
                    foreach (var shape in list)
                        Console.WriteLine(shape.Name + ", perimeter:" + shape.Perimeter());

                }
        }
    }
}
