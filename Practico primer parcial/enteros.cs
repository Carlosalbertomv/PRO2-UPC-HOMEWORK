using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

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
    
    //1.- Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros
   public int EncontrarMaximo(int[] array)
    {
       int maximo = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximo)
            {
                maximo = array[i];
            }
        }

        return maximo;
    }

    public int EncontrarMinimo(int[] array)
    {
        int minimo = array[0]; 

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        return minimo;
    }

    //2.- Retornar la suma de un array de enteros

     public void SumarArrayEnteros()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine(suma);
    }

    //3.- Retornar el promedio de un array de enteros

    public double RetornarProm(int[] array)
    {
        int suma = 0;

        foreach (int numero in array)
        {
            suma += numero;
        }

        // Calcular el promedio
        double promedio = (double)suma / array.Length;

        return promedio;

    }

     //5.- Retornar frecuencia de un elemento de un array de enteros

     public int CalcularFrecuencia(int[] array, int elementoBuscado)
    {
        int frecuencia = 0;

        foreach (int numero in array)
        {
            if (numero == elementoBuscado)
            {
                frecuencia++;
            }
        }

        return frecuencia;
    }

     //6.- Retornar frecuencia de un elemento de un array de cadenas
      



  





}