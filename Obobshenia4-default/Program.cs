using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obobshenia4_defopsefjos
{
    class MyGenericClass<T>
    {
        T a;

        public MyGenericClass()
        {
            a = default(T);
            Get_Info();
        }
        void Get_Info()
        {
            Console.WriteLine($"\n Значение типа по умолчанию: {a}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<uint> obj = new MyGenericClass<uint>();
            MyGenericClass<bool> obj1 = new MyGenericClass<bool>();
            MyGenericClass<string> obj2 = new MyGenericClass<string>();
            Console.ReadKey();
        }
    }
}