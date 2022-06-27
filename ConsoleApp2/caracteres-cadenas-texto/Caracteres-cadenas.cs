using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.caracteres_cadenas_texto
{
    internal class CaracteresCadenas
    {
        static void Init()
        {
            //CHAR//
            char[] textArrayString = { 'N', 'e', 'T' };
            string textJuntoArray = new string(textArrayString);


            //STRINGS//
            string tipoEjemplo = "NetMentor";
            string concatenacionEjemplo = tipoEjemplo + " concatenar";
            string interpolationString = $"esto es un ejemplo (tipoEjemplo)";

            Console.WriteLine(string.Format("La temperatura actual es de {0} ºC", "23"));

            string myString = "Tengo un vaso lleno de";

            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Equals("Tengo un vaso lleno de"));
            Console.WriteLine(myString.IndexOf("o"));
            Console.WriteLine(myString + " zumo de naranja");
            Console.WriteLine(myString.Contains("vaso"));


            /// STRING BUILDER igual que el string pero no duplica espacio en memoria cuando se modifica o reasigna el valor//
            StringBuilder sbEjemplo = new StringBuilder("ejemplo");
            sbEjemplo.Append(" ejemplo concatenado");
            Console.WriteLine(sbEjemplo);
        }
       
    }
}
