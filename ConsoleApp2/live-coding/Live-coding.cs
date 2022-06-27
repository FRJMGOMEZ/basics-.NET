using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class LiveCoding1{
    static void LiveCoding01(string[] args)
    {
        Ejercicios ej = new Ejercicios();

        int opcionMenu = 0;
        do
        {
            opcionMenu = Menu();
            switch (opcionMenu)
            {
                case 1:
                    ej.Ejercicio1();
                    break;
                case 2:
                    ej.Ejercicio2();
                    break;
                case 3:
                    ej.Ejercicio3();
                    break;
            }
        } while (opcionMenu != 0);
    }


    static int Menu()
    {
        Console.WriteLine("Por favor, elige una opción del menú");
        Console.WriteLine("1 - Ejercicio 1");
        Console.WriteLine("2 - Ejercicio 2");
        Console.WriteLine("3 - Ejercicio 3");
        Console.WriteLine("0 - Salir de la aplicación");
        return Convert.ToInt32(Console.ReadLine());
    }

}
   
