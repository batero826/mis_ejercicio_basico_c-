using System;

class Program
{
    static void Main(string[] args)
    {
        int valorProducto = 0;
        int totalproducto = 0;
        int numeroproducto = 0;
        Console.WriteLine("ingrese el valor del producto N.1 : ");
        valorProducto = Convert.ToInt32(Console.ReadLine());

        while (valorProducto != 99999)
        {
            numeroproducto++;
            totalproducto += valorProducto;
            Console.WriteLine("ingrese el valor del producto N." + numeroproducto + ".");
            valorProducto = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("valor total de la factura " + totalproducto);
        Console.ReadLine();

    }
}
