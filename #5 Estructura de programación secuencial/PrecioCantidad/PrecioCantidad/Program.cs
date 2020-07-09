using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. 
 * Mostrar lo que debe abonar el comprador.*/

namespace PrecioCantidad
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            float precio, total;
            string linea;

            Console.Write("Ingrese la cantidad de artículos a llevar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            Console.Write("Ingrese el valor unitario del producto: ");
            linea = Console.ReadLine();
            precio = float.Parse(linea);

            total = precio * cantidad;

            Console.Write("El importe total a pagar es: $");
            Console.Write(total);

            Console.ReadKey();
            
        }
    }
}
