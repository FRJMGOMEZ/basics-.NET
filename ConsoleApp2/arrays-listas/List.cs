using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.arrays_listas
{
    internal class List
    {

        static void Init()
        {
            List<string> ejemploListaCiudades = new List<string>();

            // convertir en array //
            string[] ejemploCiudadesArray = ejemploListaCiudades.ToArray();

            // añadir elemento //
            ejemploListaCiudades.Add("Barcelona");

            // añadir lista de elementos //
            ejemploListaCiudades.AddRange(ejemploListaCiudades);

            // cuenta elementos //
            int numeroItems = ejemploListaCiudades.Count;

            // selecciona primer elemento //
            string primeraCiudad = ejemploListaCiudades.First();

            // selecciona último elemento //
            string ultimaCiudad = ejemploListaCiudades.Last();

            // limpia array //
            ejemploListaCiudades.Clear();
        }
    }
}
