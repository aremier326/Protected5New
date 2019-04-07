using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    // Task 1.
    class A
    {
        public int a;
        public int b;
        public int C => a > b ? a - b : b - a;

        // Default constructor.
        public A()
        {
            a = 10;
            b = 15;
        }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
