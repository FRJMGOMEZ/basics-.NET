using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.arrays_listas
{
    internal class Array_multidimensional
    {
        static void Init()
        {
            //* Los array, a diferencia de las listas, son inmutables //
            string[,] ArrayCiudades = new string[2, 3];
            ArrayCiudades[0, 0] = "Zaragoza";
            ArrayCiudades[0, 1] = "Burgos";
            ArrayCiudades[0, 2] = "Vizcaya";
            ArrayCiudades[1, 0] = "Murcia";
            ArrayCiudades[1, 1] = "Cádiz";
            ArrayCiudades[1, 2] = "Huelva";

            foreach (string ciudad in ArrayCiudades)
            {
                Console.WriteLine(ciudad);
            }

        }
    }
}
