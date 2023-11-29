using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Введите номер элемента окружности (1-4):");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение элемента:");
            double value = double.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    double diameter = 2 * value;
                    double length = 2 * pi * value;
                    double area = pi * value * value;

                    Console.WriteLine("Диаметр: " + diameter);
                    Console.WriteLine("Длина: " + length);
                    Console.WriteLine("Площадь: " + area);
                    break;

                case 2:
                    double radius = value / 2;
                    length = 2 * pi * radius;
                    area = pi * radius * radius;

                    Console.WriteLine("Радиус: " + radius);
                    Console.WriteLine("Длина: " + length);
                    Console.WriteLine("Площадь: " + area);
                    break;

                case 3:
                    radius = value / (2 * pi);
                    diameter = 2 * radius;
                    area = pi * radius * radius;

                    Console.WriteLine("Радиус: " + radius);
                    Console.WriteLine("Диаметр: " + diameter);
                    Console.WriteLine("Площадь: " + area);
                    break;

                case 4: 
                    radius = Math.Sqrt(value / pi);
                    diameter = 2 * radius;
                    length = 2 * pi * radius;

                    Console.WriteLine("Радиус: " + radius);
                    Console.WriteLine("Диаметр: " + diameter);
                    Console.WriteLine("Длина: " + length);
                    break;

                default:
                    Console.WriteLine("Некорректный номер элемента.");
                    break;
            }

            Console.ReadLine();
        }
    }
}


