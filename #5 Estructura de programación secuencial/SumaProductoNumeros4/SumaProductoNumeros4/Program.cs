using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el 
 * producto del tercero y el cuarto.*/

namespace SumaProductoNumeros4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            string linea;

            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese el cuarto valor: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;

            Console.Write("La suma de primer y segundo valor es: ");
            Console.WriteLine(suma);

            Console.Write("El producto del tercer y cuarto valor es: ");
            Console.Write(producto);

            Console.ReadKey();


        }
    }
}
