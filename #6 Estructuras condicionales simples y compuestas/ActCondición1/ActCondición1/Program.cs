using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, 
en caso contrario informar el producto y la división del primero respecto al segundo.*/

namespace ActCondición1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string linea;

            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            if (num1 > num2) 
            {
                float suma, diferencia;
                
                suma = num1 + num2;
                diferencia = num1 - num2;

                Console.Write("La suma entre los dos valores es: ");
                Console.WriteLine(suma);

                Console.Write("La diferencia entre los dos valores es: ");
                Console.Write(diferencia);
            } else 
            {
                float producto, division;

                producto = num1 * num2;
                division = num1 / num2;

                Console.Write("El producto entre los dos valores es: ");
                Console.WriteLine(producto);

                Console.Write("La división entre los dos valores es: ");
                Console.Write(division);
            }

            Console.ReadKey();
        }
    }
}
