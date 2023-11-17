public class ClaseArrayC
{
    public string[] ArrayCadenas;

    public ClaseArrayC()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArrayC(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    /*4.- Buscar un elemento en un array de cadenas, en caso de encontrar el elemento en el
    array de cadenas, mostrar "TRUE" y en caso de no encontrar el elemento en el array de
    cadenas, mostrar "FALSE"*/
    public bool BuscarElemento(string[] array, string elementoABuscar)
    {
        return Array.Exists(array, cadena => cadena == elementoABuscar);
    }


    //6.- Retornar frecuencia de un elemento de un array de cadenas
    public int RetornarFrecue(string[] array, string Elemento)
    {
        int Frecuencias = 0;

        foreach (string cadena in array)
        {
            if (cadena == Elemento)
            {
                Frecuencias++;
            }
        }

        return Frecuencias;
    }

    //7.-Dado dos array (A y B)de cadenas, retornar un nuevo array (C)con el complemento deA y B
    public string[] ComplementoC(string[] arrayA, string[] arrayB)
    {
        // Utilizar Except para obtener el complemento
        string[] complemento = arrayA.Except(arrayB).ToArray();
        return complemento;
    }

    //8.- Dado un array de cadenas retornar un array de enteros con su equivalencia en ASCII
   public char[] ConvertirNumerosALetras(int[] numeros)
    {
        char[] letras = new char[numeros.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            letras[i] = (char)('A' + numeros[i] - 1);
        }

        return letras;
    }

    //9.- Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia A - B
    public string[] ObtenerDiferencia(string[] arrayC, string[] arrayD)
    {
        // Utilizar Except para obtener la diferencia
        string[] diferencia = arrayC.Except(arrayD).ToArray();
        return diferencia;
    }

    //10.- Dado un array de enteros retornar un array de cadenas con su equivalencia en ASCII
    public string[] ObtenerEquivalenciaASCII(int[] numeros)
    {
        // Utilizar Select para convertir cada entero a su representación de carácter ASCII
        string[] equivalenciaASCII = numeros.Select(numero => ((char)numero).ToString()).ToArray();

        return equivalenciaASCII;
    }

    /*11.- Invertir todos los valores de un array de cadenas, de forma que el ultimo ahora sea el
    primero, el penultimo el segundo y asi sucesivamente.*/
    public string[] InvertirArray(string[] array)
    {
        // Utilizar Reverse para invertir el array
        Array.Reverse(array);
        return array;
    }

    //12.- Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia B - A
    public string[] ObtenerDiferencias(string[] array97, string[] array98)
    {
        // Utilizar Except para obtener la diferencia
        string[] diferen = array98.Except(array97).ToArray();
        return diferen;
    }







}



