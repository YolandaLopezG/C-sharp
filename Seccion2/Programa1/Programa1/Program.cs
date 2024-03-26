using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nombre;

            ////Preguntamos el nombre del usuario
            //Console.WriteLine("¿Cual es tu nombre?");
            //nombre = Console.ReadLine();

            ////Saludamos al usuario 
            //Console.WriteLine("Hola {0}, un placer", nombre);


            //Realizar programa que haga el calculo del area y perimetro de un rectangulo

            double alto, ancho, area, perimetro;

            Console.Write("Ingrese la altura del rectangulo:");
            alto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ancho del rectangulo:");
            ancho = Convert.ToDouble(Console.ReadLine());

            area = alto * ancho;
            perimetro = (alto*2) + (ancho*2);

            Console.WriteLine("El area es: {0} y el perimetro es {1}", area, perimetro);

        }
    }
}
