using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';

        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'd')
        {
            Console.WriteLine("");
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Multiplicación de matriz por escalar");
            Console.WriteLine(" b) Devolver todas las posiciones por fila de un elemento menor");
            Console.WriteLine(" c) Vector de pares");
            Console.WriteLine(" d) Salir");
            Console.WriteLine("Ingrese opción: ");
            opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un escalar: ");
                    int escalar = Int32.Parse(Console.ReadLine());
                    operacionesMatrices.ImprimirMatriz(operacionesMatrices.MultiplicaciónMatrizEscalar(escalar));
                    break;
                case 'b':
                    Console.WriteLine("¿Qué número desea buscar dentro de la matriz?");
                    int num = Convert.ToInt32(Console.ReadLine());
                    operacionesMatrices.MatrizPosicionesNúmero(num);
                break;
                case 'c':
                    Console.Write("Los numeros pares de la matriz son: " );
                    operacionesMatrices.VectorDeNumPares();
                break;
                case 'd':
                break;
            }
        }
    }
}