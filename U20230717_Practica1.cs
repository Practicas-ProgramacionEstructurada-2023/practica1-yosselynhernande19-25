using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
         //declaracion de variables
          string? nombre;
          string? edad;
          string? direccion;
          string? telefono;
          string? universidad;
          string? carrera;
          string? facultad;
          string? ciclo;

          Console.WriteLine("\n**************Practica-1-Programación estructurada**************\n");
          Console.WriteLine("Ingrese su nombre:");
          nombre = Convert.ToString(Console.ReadLine());
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su edad:");
          edad = Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su direccion:");
          direccion = Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su telefono:");
          telefono = Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su universidad:");
          universidad = Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");
          
          Console.WriteLine("Ingrese su carrera:");
          carrera= Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su facultad:");
          facultad= Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Ingrese su ciclo:");
          ciclo = Convert.ToString(Console.ReadLine());//obtener datos
          Console.WriteLine("\n");

          Console.WriteLine("Su nombre es;" + nombre);
          Console.WriteLine("Su edad es;" + edad);
          Console.WriteLine("Su direccion es;" + direccion);
          Console.WriteLine("Su telefono es;" + telefono);
          Console.WriteLine("Su universidad es;" + universidad);
          Console.WriteLine("Su carrera es;" + carrera);
          Console.WriteLine("Su facultad es;" + facultad);
          Console.WriteLine("Su ciclo es;" + ciclo);
          


        }
    }
}
