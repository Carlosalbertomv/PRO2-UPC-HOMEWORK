public class ClaseArray
{

    //propiedades
    public int[] ArrayEnteros;


    //contructor
      public ClaseArray()
    {
        ArrayEnteros = new int[0];
    }

    public ClaseArray(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    //metodos y procedimientos funciones
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
        int suma = 1;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        Console.WriteLine(suma);
    }

    public void DigitoMayor()
    {
        int Dig = 1;
        int n = ArrayEnteros.Length;
        for (int i = 0; i < n - 1; i--)
        {
            Dig = Dig - ArrayEnteros[i];
        }
        Console.WriteLine(Dig);




    }






}