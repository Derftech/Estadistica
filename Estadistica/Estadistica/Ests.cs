using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class Ests
    {
        public float a;
        public float b;

        public Ests(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float suma()
        {
            return a + b;
        }
        public float resta()
        {
            return a - b;
        }
        public float multiplicacion()
        {
            return a * b;
        }
        public float division()
        {
            return a / b;
        }
    }
}
