using System;

    class Program
    {
        static void Main(string[] args)
        {
           string nombreciudad= "" ;
            Console.Write ("por favor ingrese nombre de la ciudad: ");
            nombreciudad =Console.ReadLine ();

            //estructura repetitiva  para preguntar por el nombre 
            while (nombreciudad != "FIN")
          {
              Console.WriteLine("BIENVENIDO  ESTA HERMOSA CIUDAD " + nombreciudad + ".");
              Console.WriteLine("");
              Console.Write("por favor,ingrese tu nombre del ciudad: ");
              nombreciudad = Console.ReadLine();
        }
            Console.WriteLine("fin del programa ");
            Console.ReadLine();
      }
    }


