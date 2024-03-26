using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer programa que calcula el perimetro de cualquier poligono regular

            double lados, largo, perimetro;

            Console.Write("Ingrese el numero de lados del poligono: ");
            lados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la medida: ");
            largo = double.Parse(Console.ReadLine());

            perimetro = lados * largo;

            Console.WriteLine("El perimetro es: {0} ", perimetro);


        }
    }
}
