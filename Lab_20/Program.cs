using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус R:");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Diameter;
            myDelegate += Square;
            myDelegate(r);
            MyDelegate myDelegate1 = Volume;
            myDelegate1(r);
            Console.ReadKey();
        }

        static double Diameter(double r)
        {
            double d = (double)Math.PI*2*(r);
            Console.WriteLine($"Диаметр составляет {d:F2}");
            return d;
        }
        static double Square(double r)
        {
            double s = (double)Math.PI*(Math.Pow( r, 2));
            Console.WriteLine($"Площадь составляет {s:F2}");
            return s;
        }

        static double Volume(double r)
        {
            double v =(double)Math.PI*(Math.Pow(r, 3))*1.3333;
            Console.WriteLine($"Объем составляет {v:F2}");
            return v;
        }
    }
}
