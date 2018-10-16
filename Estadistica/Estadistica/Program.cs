using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones básicas");
            Ests a = new Ests(0, 0);

            try
            {
                Console.WriteLine("Ingrese a: ");
                a.a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese b: ");
                a.b = float.Parse(Console.ReadLine());
                Console.WriteLine("Suma: " + a.suma());
                Console.WriteLine("Resta: " + a.resta());
                Console.WriteLine("Multiplicacíón: " + a.multiplicacion());
                Console.WriteLine("División: " + a.division());
                Console.WriteLine("Adios");
            }

            catch
            {
                Console.WriteLine("Debes ingresar números");
            }

            Console.ReadKey();
        }
    }
}
    