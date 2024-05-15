using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia5_sam2
{
    class Trapezoid<T>
    {
        T A { get; set; }
        T B { get; set; }
        T H { get; set; }
        T S { get; set; }
        public Trapezoid(T a, T b, T h)
        {
            A = a;
            B = b;
            H = h;
            Area();
        }
        void Area()
        {
            dynamic dA = A, dB = B, dH=H;
            S = (dA + dB) * dH / 2;
            Console.WriteLine($"Площадь трапеции со сторонами {dA}, {dB} и {dH} равна {S}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первой стороны трапеции= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второй стороны трапеции= ");
            double b = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Введите длину высоты трапеции= ");
            double h = Convert.ToDouble(Console.ReadLine());
            Trapezoid<double> o = new Trapezoid<double>(a, b, h);
            Console.ReadKey();
        }
    }
}