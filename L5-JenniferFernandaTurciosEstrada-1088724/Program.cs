using System.Runtime.InteropServices;

class Program 
{
    static void Main (string [] args)
    {
        string nombre;

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine(); 
        Console.WriteLine("Hola " + nombre);

        Console.WriteLine("Parte 2: Ejercicio 1: operaciones aritméticas");
        int numero1, numero2;
        int suma, resta, multi, division, mod;
        Console.WriteLine("Ingrese el primer número:");
        numero1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(numero1);
        Console.WriteLine("Ingrese el segundo número:");
        numero2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(numero2);
        
        suma = numero1 + numero2;
        Console.WriteLine("El resultado de la suma es: " + numero1 + " + " + numero2 + " = " + suma);
        
        resta = numero1 - numero2;
        Console.WriteLine("El resultado de la resta es: " + numero1 + " - " + numero2 + " = " + resta);
        
        multi = numero1 * numero2;
        Console.WriteLine("El resultado de la multiplicación es: " + numero1 + " * " + numero2 + " = " + multi);
        
        division = numero1/numero2;
        Console.WriteLine("El resultado de la división: " + numero1 + " / " + numero2 + " = " + division);
        
        mod = numero1 % numero2; 
        Console.WriteLine("El residuo de la división es: " + numero1 + " % " + numero2 + " = " + mod);

        Console.Write("Ejercicio 2: operaciones booleanas");

        Console.WriteLine(numero1 + "<" + numero2 + "=" + (numero1<numero2));
        Console.WriteLine(numero1 + ">" + numero2 + "=" + (numero1>numero2));
        Console.WriteLine(numero1 + "==" + numero2 + "=" + (numero1==numero2));

        Console.WriteLine("Ejercicio 3: jerarquía de operaciones");

        int a, b, c; 
        Console.WriteLine("Ingrese el primer número: ");
        a= Int32.Parse(Console.ReadLine()); 

        Console.WriteLine("Ingrese el segundo número: ");
        b = Int32.Parse(Console.ReadLine());

        Console.WriteLine ("Ingrese el tercer número: ");
        c = Int32.Parse(Console.ReadLine());

        Double i, ii, iii, iv;

        i = (a*b)+c;
        Console.WriteLine("El resultado de la operación a*b+c es igual a: " + i);

        ii = a * (b+c);
        Console.WriteLine("El resultado de la operación a*(b+c) es igual a: " + ii);

        iii = a / (b*c);
        Console.WriteLine("El resultado de la operación a/b*c es igual a: " + iii);

        iv = ((3*a) + (2*b))/(c*c);
        Console.WriteLine("El resultado de la operación 3a+2b/c² es igual a: " + iv);

        Console.WriteLine("Ejercicio 4: fórmula cuadrática"); 
        Console.WriteLine("Se recomienda utilizar números distintos a 0");

        double a2;
        double b2;
        double c2;
        Console.WriteLine("Ingrese un numero");
        a2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo numero");
        b2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un tercer numero");
        c2 = Int32.Parse(Console.ReadLine());

        double discriminante = ((b2*b2)-4*a2*c2);
        double x1 = 0;
        double x2 = 0;
        double raiz= Math.Sqrt(discriminante);
        double numerador1 = (-b2) + raiz;
        double numerador2 = (-b2) - raiz;

        if (a2!= 0 && discriminante >= 0)
        {
            x1 = numerador1/(2*a2);
            x2 =  numerador2/(2*a2);
            Console.WriteLine("Los posibles resultados de la fórmula cuadrática son: " );
            Console.WriteLine(+ x1);
            Console.WriteLine(+ x2);
        }
        else 
        {
            if (a2==0)
            {
                Console.WriteLine("La operación no es posible de realizar a casusa de que su primer número ingresado es igual a 0");
            }
            if (discriminante <= 0)
            {
                Console.WriteLine("La operación no es posible de realizar a causa de que el discriminante de la fórmula cuadrática da como resultado 0");

            }
        }
    }
}
