using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Ejercicios
    {

        public void Ejercicio1()
        {
            Console.Write("Introduce un número");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce otro número");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            for(int i = numero1; i <= numero2; i++){
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
         
    public void Ejercicio2()
    {
        Console.Write("Introduce un número por favor");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numero1; i++)
        {
            int sumaDivisores = 0;
            for(int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    sumaDivisores += j;
                }
            }
            if(sumaDivisores == i)
            {
                Console.WriteLine("{0} es un número perfecto", i);
            }
        }

       }

    public void Ejercicio3()
    {
        string nombre = "";
        do
        {
            Console.Write("Por favor introduce un nombre:");
            nombre = Console.ReadLine();
        } while (nombre.ToLower() != "netmentor");
        Console.Write("Nombre introducido correctamente");
    }

    
    }

