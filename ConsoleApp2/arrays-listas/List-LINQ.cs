using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.arrays_listas
{
    internal class List_LINQ
    {
        static void Init()
        {
            List<string> ejemploListaCiudades = new List<string>();
            ejemploListaCiudades.Add("Barcelona");
            ejemploListaCiudades.Add("Pamplona");
            ejemploListaCiudades.Add("Castellon");
            IEnumerable<string> ciudadesEncontradas = ejemploListaCiudades.Where(x => x.ToLower().Contains("e"));

            foreach (var ciudad in ciudadesEncontradas)
            {
                Console.WriteLine(ciudad);
            }
        }
    }
}
