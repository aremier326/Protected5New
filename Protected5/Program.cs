using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.C);
            B b = new B(3);

            Console.WriteLine($"a = {b.a}, b = {b.b}, d = {b.d}");
        }
    }
}
