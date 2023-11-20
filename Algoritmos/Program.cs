using System.Linq;
namespace Clase8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //suma de enteros
            ClaseArray A = new ClaseArray(2);
            A.ArrayEnteros[0] = 1;
            A.ArrayEnteros[1] = 9;
            A.MostrarArray();
            A.SumarElementosArray();
            Console.WriteLine("--------------------");
            //digito mayor y menor

            int[] arr = { 8, 3, 5, -1, 2 };
            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
            Console.WriteLine("--------------------");

            //Calcular el fibonacci del digito menor de un número
            //Console.Write("Ingrese un número entero: ");
            /*int numero = Convert.ToInt32(Console.ReadLine());

            ClaseArray calculator = new ClaseArray();
            int resultado = calculator.CalcularFibonacciDelDigitoMenor(numero);

            //Console.WriteLine($"El número de Fibonacci del dígito menor de {numero} es: {resultado}");*/


            //Invertir la segunda mitad de un array de enteros
            //unir dos array enteros
            Console.WriteLine("Ordenamiento por Sort y Reverse");
            int[] arregloNumeros = new int[] { 1, 4, 2, 7, 55, 9, 7, 10, 99, 3 };
            Array.Sort(arregloNumeros);
            Console.WriteLine(string.Join(", ", arregloNumeros));

            //Ordernar desendentemente un array de enteros
            Console.WriteLine("Ordenamiento por Sort y Reverse");
            int[] arregloNu = new int[] { 1, 4, 2, 7, 55, 9, 7, 10, 99, 3 };
            Array.Sort(arregloNu);
            Array.Reverse(arregloNu);
            Console.WriteLine(string.Join(", ", arregloNu));
            

            

           

 


             
        }
           

            

        
    }
}