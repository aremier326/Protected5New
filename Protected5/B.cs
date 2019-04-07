using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected5
{
    // Task 2.
    class B : A
    {
        public int d;
        public int C2 => a + b + d;

        public B() {}

        public B(int d)
        : this(d: d, a: 0, b: 0) {}
        
        public B(int a, int b, int d) : base(a, b) => this.d = d;

    }
}
