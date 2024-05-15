using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia5_sam3
{
    class Generalized<T1, T2>
    {
        T1 val1 { get; set; }
        T2 val2 { get; set; }
        public Generalized(T1 val1, T2 val2)
        {
            this.val1 = val1;
            this.val2 = val2;
            GetInfo();
        }
        void GetInfo()
        {
            Console.WriteLine($"Первое значение: {val1}, второе значение: {val2}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение= ");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе значение= ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Generalized<double,int> o = new Generalized<double, int>(val1, val2);
            Console.ReadKey();
        }
    }
}
