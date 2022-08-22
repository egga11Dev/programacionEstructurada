// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Arreglo
{
  class Arreglo
  {
    int[] edades;
    int result = 0;
    public void recibe()
    {
      edades = new int[10];
      for (int i = 0; i < edades.Length; i++)
      {
        Console.Write("Ingrese la edad: " + (i + 1) + ": ");
        edades[i] = int.Parse(Console.ReadLine());
      }
      Console.Write("Calculando el promedio… \n");
      for (int i = 0; i < edades.Length; i++)
      {
        result += edades[i];
      }
      Console.WriteLine("la edad promedio es: " + result / 10);
    }

    static void Main(string[] args)
    {
      Arreglo alumnos = new Arreglo();
      alumnos.recibe();
      Console.ReadKey();
    }


  }
}


