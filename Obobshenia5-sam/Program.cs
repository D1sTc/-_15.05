using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia5_sam
{
    class Point<T1>
    {
        T1 X { get; set; }
        T1 Y { get; set; }
        public Point(T1 a, T1 b)
        {
            X = a;
            Y = b;
            Info();
        }
        void Info()
        { Console.WriteLine($"x= {X}, а y= {Y}") ; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> o = new Point<int>(23,15);
            Point<double> o1 = new Point<double>(7.88, -3.22);
            Console.ReadKey();
        }
    }
}