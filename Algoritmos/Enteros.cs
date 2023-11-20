using System.Diagnostics.Contracts;

public class ClaseArray
{
    //Propiedades
    public int[] ArrayEnteros;

    //Constructor
    public ClaseArray()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public void SumarElementosArray()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine(suma);
    }

    public int CalcularFibonacciDelDigitoMenor(int numero)
    {
        int digitoMenor = ObtenerDigitoMenor(numero);
        int fibonacciDigitoMenor = CalcularFibonacci(digitoMenor);
        return fibonacciDigitoMenor;
    }

    private int ObtenerDigitoMenor(int numero)
    {
        int digitoMenor = Math.Abs(numero) % 10;

        while (numero > 0)
        {
            int digitoActual = Math.Abs(numero) % 10;
            digitoMenor = Math.Min(digitoMenor, digitoActual);
            numero /= 10;
        }

        return digitoMenor;
    }

    private int CalcularFibonacci(int n)
    {
        if (n <= 1)
            return n;

        int fibAnterior = 0;
        int fibActual = 1;

        for (int i = 2; i <= n; i++)
        {
            int temp = fibActual;
            fibActual = fibAnterior + fibActual;
            fibAnterior = temp;
        }

        return fibActual;
    }

    public void UnirArray(ClaseArray D)
    {
        int n1 = ArrayEnteros.Length;
        int n2 = D.ArrayEnteros.Length;
        int newN = n1 + n2;
        ClaseArray C = new ClaseArray(newN);
        for (int i = 0; i <= n1 - 1; i++)
        {
            C.ArrayEnteros[i] = ArrayEnteros[i];
        }
        for (int j = 0; j <= n2 - 1; j++)
        {
            C.ArrayEnteros[n1 + j] = D.ArrayEnteros[j];
        }
        ArrayEnteros = C.ArrayEnteros;

    }

   

    

    
  


}