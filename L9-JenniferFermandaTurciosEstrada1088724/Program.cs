using System;

class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil();
        
        Console.WriteLine("Por favor ingrese los siguientes datos del automóvil:");
        Console.WriteLine("Modelo: ");
        int modelo = Convert.ToInt32(Console.ReadLine());
        objAutomovil.DefinirModelo(modelo);
        Console.WriteLine("");

        Console.WriteLine("Precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        objAutomovil.DefinirPrecio(precio);
        Console.WriteLine("");

        Console.WriteLine("Marca: ");
        string marca = Console.ReadLine();
        objAutomovil.DefinirMarca(marca);
        Console.WriteLine("");

        Console.WriteLine("Tipo de cambio: ");
        double tipoCambioDolar = Convert.ToDouble(Console.ReadLine());
        objAutomovil.DefinirTipoCambio(tipoCambioDolar);
        Console.WriteLine("");

        Console.WriteLine("Los datos del automovil son los siguientes: ");
        Console.WriteLine(objAutomovil.MostrarInformacion());
        Console.WriteLine("");

        Console.WriteLine("¿Desea cambiar la disponibilidad del automóvil? (Disponibilidad actual: " + objAutomovil.MostrarDisponibilidad() + " (0 = no , 1 = sí)");
        string respuestadisponibilidad = Console.ReadLine();
        Console.WriteLine("");

        if (respuestadisponibilidad == "1")
        {
            objAutomovil.CambiarDisponibilidad();
            Console.WriteLine("El nuevo estado de disponibilidad es: " + objAutomovil.MostrarDisponibilidad());
        }
        Console.WriteLine("");

        Console.WriteLine("Por favor, ingrese el monto de descuento a aplicar: ");
        double descuento = Convert.ToDouble(Console.ReadLine());
        objAutomovil.AplicarDescuento(descuento);
        Console.WriteLine("");

        Console.WriteLine("Los datos actualizados del automóvil son los siguientes: ");
        Console.WriteLine(objAutomovil.MostrarInformacion());
    }
}

class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double tipoCambioDolar;
    private double descuentoAplicado;

    public Automovil()
    {
        modelo = 2019;
        precio = 10000.00;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.50;
        descuentoAplicado = 0.00;
    }

    public void DefinirModelo (int unModelo)
    {
        modelo = unModelo;
    }
    
    public void DefinirPrecio (double unPrecio)
    {
        precio = unPrecio;
    }

    public void DefinirMarca (string unaMarca)
    {
        marca = unaMarca;
    }

    public void DefinirTipoCambio (double unTipoCambio)
    {
        tipoCambioDolar = unTipoCambio;
    }

    public void CambiarDisponibilidad ()
    {
        disponible = !disponible;
    }

    public string MostrarDisponibilidad ()
    {
        return disponible ? "Disponible" : "No se encuentra disponible en este momento";
    } 

    public string MostrarInformacion ()
    {
        double precioEnDolares = precio / tipoCambioDolar;
        return "Marca: "+ marca + ". Modelo: "+ modelo + ". Precio de venta Q." + precio + ". Precio en dólars $. " + precioEnDolares + ". " + MostrarDisponibilidad();
    }

    public void AplicarDescuento (double miDescuento)
    {
        descuentoAplicado = miDescuento;
        double precioDescuento = precio - descuentoAplicado;
        DefinirPrecio (precioDescuento);
    }
}

