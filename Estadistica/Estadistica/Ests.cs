using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class Ests
    {
        public int a;
        public int b;

        public Ests(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int suma()
        {
            return a + b;
        }
        public int resta()
        {
            return a - b;
        }
        public int multiplicacion()
        {
            return a * b;
        }
        public int division()
        {
            return a / b;
        }
    }
}
