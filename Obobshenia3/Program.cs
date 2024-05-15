using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia3
{
    class Account<T1,T2>
    {
        public T2 ID { get; set; }
        public T1 Sum { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<int,int> acc1 = new Account<int, int>();
            acc1.Sum = 4204;
            acc1.ID = 1; // boxing 

            Account<int, string> acc2 = new Account<int, string>();
            acc2.Sum = 5220;
            acc2.ID = "2"; // boxing

            Console.WriteLine($"id счёта: {(int)acc1.ID}, сумма на счету: {acc1.Sum}"); // unboxing - int
            Console.WriteLine($"id счёта: {(string)acc2.ID}, сумма на счету: {acc2.Sum}"); // unboxing - string
            Console.ReadKey();
        }
    }
}
