﻿using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionPruebasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola desde consola");
            
            Console.WriteLine(Pruebas.Sumar(1, 21));
            Console.WriteLine("Hola desde consola yo Angel ");
            Console.WriteLine(Pruebas.Sumar(234, 54));
            Console.WriteLine("Hola desde consola yo asier");
        }
    }
}
