class Program
{
    static void Main(string[] args)
    {
        int numeroMes;
        string entradaMes;
        string mesCadena;

        Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el nombre del mes");
        entradaMes = Console.ReadLine();

        if(int.TryParse(entradaMes, out numeroMes))
        {
            Console.WriteLine($"Seconvirtió '{entradaMes}' a '{numeroMes}'");
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número del 1 al 12");
        }

        Console.WriteLine(numeroMes);

        switch(numeroMes)
        {
            case 1:
            mesCadena= "Enero";
            break;
            case 2:
            mesCadena= "Febrero";
            break;
            case 3:
            mesCadena= "Marzo";
            break;
            case 4:
            mesCadena= "Abril";
            break;
            case 5:
            mesCadena= "Mayo";
            break;
            case 6:
            mesCadena= "Junio";
            break;
            case 7:
            mesCadena= "Julio";
            break;
            case 8:
            mesCadena= "Agosto";
            break;
            case 9:
            mesCadena= "Septiembre";
            break;
            case 10:
            mesCadena= "Octubre";
            break;
            case 11:
            mesCadena= "Noviembre";
            break;
            case 12:
            mesCadena= "Diciembre";
            break;
            default:
            mesCadena = "";
            Console.WriteLine("Error: Debe ingresar un numero del 1 al 12");
            break;
        }

        Console.WriteLine($"MES:'{mesCadena}' ");

        Console.WriteLine("Ejercicio#2");
        int a, b, c;

        Console.WriteLine("Ingrese 3 números mayores a 0");
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        int.TryParse(Console.ReadLine(), out c);

        if(a > b)
        {
            if (a > c)
            {
                Console.WriteLine($"RESULTADO: El número mayor es: '{a}'" );
            }
            else if (a == c)
            {
                Console.WriteLine($"RESULTADO: Los número mayores son: '{a}' y '{c}'");
            }
            else 
            {
                if (c > a)
                {
                Console.WriteLine($"RESULTADO: El número mayor es: '{c}'" );
                }
            }
        }
        else if (a == b)
        {
            if (a > c)
            {
                Console.WriteLine($"RESULTADO: Los números mayores son: '{a}' y '{b}', son iguales");
            }
            else if (a == c)
            {
                Console.WriteLine($"RESULTADO: Los números son iguales");
            }
            else
            {
                if (c > a)
                {
                    Console.WriteLine($"RESULTADO: El número mayor es: '{c}'" );
                }
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine($"RESULTADO: El número mayor es: '{b}'");
            }
            else if (b == c)
            {
                Console.WriteLine($"RESULTADO: Los números mayores son: '{b}' y '{c}', son iguales");
            }
            else
            {
                if (c > b)
                {
                    Console.WriteLine($"RESULTADO: El número mayor es: '{c}'" );
                }
            }
        }

         Console.WriteLine("Tarea");

        int nmes;
        int ndia;
        int naño;
        string mes;
        string dia;
        string año;
        string signo;

        Console.WriteLine("Ingrese el número del dia en que nació");
        dia = Console.ReadLine();
        Console.WriteLine("Ingrese el número del mes en que nació");
        mes = Console.ReadLine();
        Console.WriteLine("Ingrese el año en que nació");
        año = Console.ReadLine(); 

        if(int.TryParse(dia, out ndia))
        {
            Console.WriteLine($"Seconvirtió '{dia}' a '{ndia}'");
        }
        if(int.TryParse(mes, out nmes))
        {
            Console.WriteLine($"Seconvirtió '{mes}' a '{nmes}'");
        }
        if(int.TryParse(año, out naño))
        {
            Console.WriteLine($"Seconvirtió '{año}' a '{naño}'");
        }
 
        switch (nmes)
        {
            case 1:
             if (ndia > 20)
             {
                signo = "ACUARIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "CAPRICORNIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break; 
            case 2: 
            if (ndia > 18)
             {
                signo = "PISCIS";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "ACUARIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 3: 
            if (ndia > 20)
             {
                signo = "ARIES";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "PISCIS";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 4: 
            if (ndia > 19)
             {
                signo = "TAURO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "ARIES";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 5: 
            if (ndia > 20)
             {
                signo = "GÉMINIS";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "TAURO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 6: 
            if (ndia > 20)
             {
                signo = "CÁNCER";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "GÉMINIS";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 7: 
            if (ndia > 22)
             {
                signo = "LEO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "CÁNCER";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 8: 
            if (ndia > 22)
             {
                signo = "VIRGO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "LEO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 9: 
            if (ndia > 22)
             {
                signo = "LIBRA";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "VIRGO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 10: 
            if (ndia > 22)
             {
                signo = "ESCORPIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "LIBRA";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 11: 
            if (ndia > 21)
             {
                signo = "SAGITARIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "ESCORPIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
            case 12: 
            if (ndia > 21)
             {
                signo = "CAPRICORNIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
             else
             {
                signo = "SAGITARIO";
                Console.WriteLine($"Su signo del zodiaco es: '{signo}'");
             }
            break;
        }
    }
}
