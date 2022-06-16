using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Расчет периметра и площади прямоугольника");
            Console.WriteLine("Введите длину 1-й стороны:");
            string a = Console.ReadLine();
            double storona1 = Convert.ToDouble(a);

            Console.WriteLine("Введите длину 2-й стороны:");
            string b = Console.ReadLine();
            double storona2 = Convert.ToDouble(b);

            Rectangle my_rectangle = new Rectangle(storona1, storona2);
            Console.WriteLine("Площадь = {0}(^2)", my_rectangle.Area);
            Console.WriteLine("Периметр = {0}", my_rectangle.Perimetr);
            Console.ReadKey();
        }
    }
}
