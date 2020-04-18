using System;

class Program
{
    static void Main(string[] args)
    {
        string respuesta = "";
        int valorProducto = 0;
        int totalproducto = 0;
        int numeroproducto = 0;
        int totalcompla = 0;
        int cantidad = 0;

        Console.WriteLine("desea agregar productos al carrito si/no");
        respuesta = Console.ReadLine();
        while (respuesta == "si")
        {
            numeroproducto++;

            Console.WriteLine("ingrese valor  del producto N.1 : " + numeroproducto + ":");
            valorProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad del producto");
             cantidad = Convert.ToInt32(Console.ReadLine());
            totalproducto = valorProducto * cantidad;
            totalcompla += totalproducto;

            Console.WriteLine("desea agregar mas productos al carrito si/no ");
            respuesta = Console.ReadLine();

        }
        Console.WriteLine("valor total de la factura " + totalcompla);
        Console.WriteLine("gracias por su compra ");
        Console.ReadLine();

    }
}
