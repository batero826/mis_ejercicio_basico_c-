using System;

class Program
{
    static void Main(string[] args)
    {
        int dia = 0;
        int mes = 0;
        int anyo= 0;
        string mesletra="";

        Console.WriteLine("por favor ingrese el dia de nacimiento: ");
        dia= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("por favor ingrese el mes de nacimiento: ");
        mes= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("por favor ingrese el años de nacimiento: ");
         anyo= Convert.ToInt32(Console.ReadLine());

        switch(mes)
        {
            case 1:
                mesletra ="enero";
                break;
           case 2:
                mesletra ="febrero";
                break;
           case 3:
                mesletra ="marzo";
                break;
           case 4:
                mesletra ="abrir";
                break;
            case 5:
                mesletra ="mayo";
                break;
            case 6:
                mesletra ="junio";
                break;
            case 7:
                mesletra ="julio";
                break;   
             case 8:
                mesletra ="agosto";
                break;
           case 9:
                mesletra ="septiembre";
                break;
           case 10:
                mesletra ="octubre";
                break;
           case 11:
                mesletra ="noviembre";
                break;
            case 12:
                mesletra ="diciembre";
                break;
            default:
                mesletra = "error";
                break;

    }
        if (mesletra "ERROR ");
}
Console.WriteLine ("")
        Console.ReadLine();
    
}

}

