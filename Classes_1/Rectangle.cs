using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Rectangle
    {
        private double side1, side2; //создаем в классе Rectangle поля side1 и side2

        public Rectangle(double side1, double side2) //создаем пользовательский конструктор Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator() //создаем метод AreaCalculator
        {
            double area = side1 * side2;
            return area;
        }

        private double PerimetrCalculator() //создаем метод PerimetrCalculator
        {
           double perimetr = (side1 * 2) + (side2 * 2);
           return perimetr;
        }

        public double Area //создаем свойство double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimetr //создаем свойство double Perimetr
        {
            get { return PerimetrCalculator(); }
        }
    }
}
