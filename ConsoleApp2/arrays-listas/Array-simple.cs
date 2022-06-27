using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.arrays_listas
{
    internal class ArraySimple
    {

        static void Init()
        {
            int[] arrayEnteros = new int[5];
            int[] arrayAsigEnteros = { 25, 27, 25, 29, 20 };

            for (int i = 0; i < arrayAsigEnteros.Length; i++)
            {
                Console.WriteLine($"La edad es {arrayAsigEnteros[i]}");
            }

            Console.WriteLine(Media(arrayAsigEnteros));

        }

        public static int Suma(int[] arrayEnteros)
        {
            int result = 0;
            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                result += arrayEnteros[i];
            }
            return result;
        }

        public static decimal Media(int[] arrayEnteros)
        {
            int sum = Suma(arrayEnteros);
            decimal result = (decimal)sum / arrayEnteros.Length;

            return result;
        }
    }
}
