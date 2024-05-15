using System.Data;

class Program
{
    static void Main(string []args)
    {
        int NFibonacci;
        bool conversionAInt= false;
        bool nPositivo = false;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conversionAInt = int.TryParse(Console.ReadLine(), out NFibonacci);
            if (conversionAInt)
            {
                if (NFibonacci > 0)
                {
                    nPositivo = true;
                }
            }
        }
        while(!conversionAInt || !nPositivo);

        Console.WriteLine("");
        Console.WriteLine("Serie Fibonacci:");
        int a = 0;
        int b = 1;
        int c = 0;
        int i = 2;
        string resultado ="";
        int result;

        if (conversionAInt)
        {
            if (NFibonacci > 0)
            {
                int.TryParse(resultado, out result);
                result = a;
                Console.WriteLine($"'{result}'");

                if (NFibonacci > 1)
                {
                int.TryParse(resultado, out result);
                result = b;
                Console.WriteLine($"'{result}'");

                    while (i < NFibonacci) 
                    {
                    int.TryParse(resultado, out result);
                    c = a+b; 
                    result= c;
                    a=b;
                    b=c;
                    i++;
                    Console.WriteLine($"'{result}'");
                    }
                }
                else
                {
                    Console.WriteLine(resultado);
                }
            }
            else
            {
                Console.WriteLine("ERROR: El número es menor a 0 " + resultado);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Tarea:");

        int n;
        double cont = 1;
        double resultop;
        double  final = 0;

        Console.WriteLine("Ingrese un número mayor a 0:");
        n = Int32.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.Write("Serie A: ");
        Console.WriteLine("");
        do
        {
            Console.Write($"1/{cont} + ");
            resultop = 1/cont;
            final = final+resultop;

            cont++;
        }
        while (cont <= n);
        Console.WriteLine("");
        Console.WriteLine("Resultado = " + final);
        Console.WriteLine("");
        
        Console.WriteLine("Serie B: ");

        double cont2 = 1;
        double resultop2;
        double  final2 = 0;
        do
        {
            Console.Write($"1/2^{cont2} + ");
            resultop2 = 1/Math.Pow(2, cont2);
            final2 = final2 + resultop2;
            cont2++;
        }
        while (cont2 <= n);
        Console.WriteLine("");
        Console.WriteLine("Resultado = " + final2);

        Console.WriteLine("");
        Console.WriteLine("Serie C: ");

        int x;
        int y;
        int k = 0;
        double resultop3 = 0;
        double final3 = 0;

        Console.WriteLine("(x)Ingrese un número mayor a 0:");
        x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("(a)Ingrese un número mayor a 0:");
        y = Int32.Parse(Console.ReadLine());

        do
        {
            resultop3 = (Math.Pow(x, k))*(Math.Pow(y, (n-k)));
            final3 = final3 + resultop3;
            k++;
        }
        while (k <= n);
        Console.WriteLine("Resultado = " + final3);
    }
}
