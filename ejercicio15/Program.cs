﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Informar cuantos días faltan para el 25/12/2020 -> (25/12/2024).*/

            DateTime fechaActual = DateTime.Now;
            DateTime fechaNavidad = new DateTime(2024,12,25);
            TimeSpan diasFaltantesParaNavidad;


            diasFaltantesParaNavidad = fechaNavidad - fechaActual;

            Console.WriteLine($"Faltan {diasFaltantesParaNavidad.Days} dias para navidad");


            Console.ReadKey();


        }
    }
}
