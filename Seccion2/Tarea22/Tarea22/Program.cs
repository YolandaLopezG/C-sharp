using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grados, faren;
            Console.Write("Ingrese los grados Centigrados:");
            grados = double.Parse(Console.ReadLine());
            faren = (1.8 * grados) + 32;
            Console.WriteLine("Grados Fahrenheit {0} ", faren);
            

        }
    }
}
