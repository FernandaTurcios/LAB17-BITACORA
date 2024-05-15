class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EJERCICIO 2");
        Personaje personaje = new Personaje(0, 0);

        string opcion;

        do
        {
        Console.WriteLine("Ingerese la opción:");
        Console.WriteLine("a. Sube");
        Console.WriteLine("b. Baja");
        Console.WriteLine("c. Izquierda");
        Console.WriteLine("d. Derecha");
        Console.WriteLine("e. Salir");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "a":
                personaje.MoverHaciaArriba(LeerCantidad("arriba"));
                break;
            case "b":
                personaje.MoverHaciaArriba(LeerCantidad("abajo"));
                break;
            case "c":
                personaje.MoverHaciaArriba(LeerCantidad("izquierda"));
                break;
            case "d":
                personaje.MoverHaciaArriba(LeerCantidad("derecha"));
                break;
            case "e":
                Console.WriteLine("Coordenadas finales del personaje: " + personaje.GetX() + ", "  + personaje.GetY());
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        } while (opcion != "e");

        Console.WriteLine("");
        Console.WriteLine("EJERCICIO 1:");

        Console.WriteLine("Menú de opciones");
        Console.WriteLine("a. Calcular área de un triángulo");
        Console.WriteLine("b. Calcular área de un cuadrado");
        Console.WriteLine("c. Calcular área de un rectángulo");
        Console.WriteLine("d. Calcular área de un círculo");
        string opcion2 = Console.ReadLine();
        Areas objareas = new Areas();

        switch (opcion2)
        {   
        case "a":
            Console.WriteLine("Ingrese el valor de la base:");
            double Base=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura:");
            double Altura=double.Parse(Console.ReadLine());
            double AreaTriangulo= objareas.ObtenerAreaTriangulo(Base,Altura);
            Console.WriteLine(AreaTriangulo);
            break;
         case "b":
            Console.WriteLine("Ingrese el valor del lado:");
            double Lado=double.Parse(Console.ReadLine());
            double  AreaCuadrado= objareas.ObtenerAreaCuadrado(Lado);
            Console.WriteLine(AreaCuadrado);
            break;
        case "c":
            Console.WriteLine("Ingrese el valor de la base:");
            double Baserec=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura");
            double Alturarec=double.Parse(Console.ReadLine());
            double AreaRectangulo= objareas.ObtenerAreaTriangulo(Baserec,Alturarec);
            Console.WriteLine(AreaRectangulo);
            break;
        case "d":
            Console.WriteLine("Ingrese el valor de el radio");
            double radio=double.Parse(Console.ReadLine());
            double  AreaCirculo= objareas.ObtenerAreaCuadrado(radio);
            Console.WriteLine(AreaCirculo);
            break;
        }
    

    }

    static int LeerCantidad(string direccion)
    {
        Console.WriteLine("Ingrese la cantidad a moverse hacia {direccion}:");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }
    

}

