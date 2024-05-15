using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];

    public OperacionesMatrices()
    {
    }
    public void CrearMatriz()
    {
        int cantidadFilas = 0;
        int cantidadCols = 0;

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());
        Console.WriteLine("");

        matriz = new int[cantidadFilas,cantidadCols];
    }
    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  
    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void ImprimirMatriz(int [,] x)
    {
        for (int i = 0; i < x.GetLength(0); i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < x.GetLength(1); j++)
            {
                Console.Write(x[i, j] + "\t");
            }
        }
        Console.ReadKey();
    }

    public void MatrizPosicionesNúmero (int num)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j] == num)
                {
                    Console.Write("Las posiciones en las que se encuentra dicho número son: ");
                    Console.WriteLine("");
                    Console.Write(i + "\t" + j + "\t");
                    Console.WriteLine("");
                }
            }
        }
        Console.ReadKey();
    }

    public void VectorDeNumPares ()
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int numpar = matriz [i,j] % 2;
                if (numpar == 0)
                {
                    Console.Write(matriz [i, j] + ",");
                    Console.WriteLine("");
                }
            }
        }
        Console.ReadKey();
    }

}