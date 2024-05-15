using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia
{
    class Terem<T1>
    {
        static Terem()
        {}
        public string Info(T1 val1, T1 val2)
        { return $"Ваше ФИО {val1}, а группа {val2}"; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО ");
            string FIO = Console.ReadLine();
            Console.Write("Введите группу ");
            string group = Console.ReadLine();
            Terem <string> o=new Terem< string> ();
            Console.WriteLine(o.Info(FIO, group));
            Console.ReadKey();
        }       
    }
}
