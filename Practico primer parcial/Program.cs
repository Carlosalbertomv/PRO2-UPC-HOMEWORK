using System.Runtime.InteropServices;

namespace Practico
{
    public class Program{
        public static void Main(string[] args)
        {
            int[] numeros = { 4, 8, 100, 5, 2, 9, 3, 7 };
            ClaseArray number = new ClaseArray();
         //1.- Encontrar el máximo o el mínimo y mostrarlo en la consola de un array de enteros
            int maximo = number.EncontrarMaximo(numeros);
            int minimo = number.EncontrarMinimo(numeros);

            Console.WriteLine("El Maximo es:" + maximo);
            Console.WriteLine("El Minimo es:" + minimo);

            Console.WriteLine("-----------------------");


         //2.- Retornar la suma de un array de enteros
            ClaseArray A = new ClaseArray(2);
            A.ArrayEnteros[0] = 100;
            A.ArrayEnteros[1] = 9;

            A.MostrarArray();
            A.SumarArrayEnteros();

            Console.WriteLine("-----------------------");
         //3.- Retornar el promedio de un array de enteros
            int[] Numeros = { 4, 8, 100, 5, 2, 9, 3, 7 };
            ClaseArray Prome = new ClaseArray();
            double Promedio = Prome.RetornarProm(Numeros);
            Console.WriteLine("El promedio es:" + Promedio);

            Console.WriteLine("-----------------------");
         /*4.- Buscar un elemento en un array de cadenas, en caso de encontrar el elemento en el
           array de cadenas, mostrar "TRUE" y en caso de no encontrar el elemento en el array de
           cadenas, mostrar "FALSE"*/


            string[] cadenas = { "Hola", "Mundo", "Programación", "C#" };
            string elementoABuscar = "Hola"; 

            ClaseArrayC VoF = new ClaseArrayC();
            bool encontrado = VoF.BuscarElemento(cadenas, elementoABuscar);
            Console.WriteLine("Existe el elemento: ");
            Console.WriteLine(encontrado ? "TRUE" : "FALSE");

            Console.WriteLine("-----------------------");
         //5.- Retornar frecuencia de un elemento de un array de enteros
            int[] Number = { 4, 8, 1, 5, 2, 9, 3, 7, 4, 8, 4, 4 };
            int elementoBuscado = 9;
            ClaseArray frecu = new ClaseArray();
            int frecuencia = frecu.CalcularFrecuencia(Number, elementoBuscado);
            Console.WriteLine($"La frecuencia de {elementoBuscado} es: {frecuencia}");

            Console.WriteLine("-----------------------");
         //6.- Retornar frecuencia de un elemento de un array de cadenas
            string[] Cadena = { "hello", "juan", "hello", "bronco", "joan", "hello"};
            string Elemento = "hello";
            ClaseArrayC Frecue = new ClaseArrayC();
            int Frecuencias = Frecue.RetornarFrecue(Cadena, Elemento);
            Console.WriteLine($"La frecuencia de '{Elemento}' es: {Frecuencias}");

            Console.WriteLine("-----------------------");
         //7.-Dado dos array(A y B)de cadenas,retornar un nuevo array (C) con el complemento de A y B
            string[] arrayA = { "Hola", "Mundo", "Progra2", "Class" };
            string[] arrayB = { "Mundo", "Class" };

            ClaseArrayC utilidades = new ClaseArrayC();
            string[] complemento = utilidades.ComplementoC(arrayA, arrayB);

           Console.WriteLine("Complemento de A y B es:");
           foreach (string elemento in complemento)
           {
             Console.WriteLine(elemento);
           }

           Console.WriteLine("-----------------------");
           //8.- Dado un array de cadenas retornar un array de enteros con su equivalencia en ASCII
           int[] un = { 97, 98, 99, 100 };

           ClaseArrayC Convertir = new ClaseArrayC();

           char[] letras = Convertir.ConvertirNumerosALetras(un);
           Console.WriteLine("Letras correspondientes a los números:");
           foreach (char letra in letras)
           {
               Console.Write(letra + " ");
           }

           Console.WriteLine("-----------------------");
           //9 .- Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia A - B
           string[] arrayC = { "Hola", "Mundo", "Programación", "C#" };
           string[] arrayD = { "Mundo", "C#" };

           ClaseArrayC Diferenciales = new ClaseArrayC();
           string[] diferencia = Diferenciales.ObtenerDiferencia(arrayC, arrayD);
           Console.WriteLine("Diferencia C - D:");
           foreach (string Element in diferencia)
           {
               Console.WriteLine(Element);
           }


           Console.WriteLine("-----------------------");
           //10.- Dado un array de enteros retornar un array de cadenas con su equivalencia en ASCII
            int[] Us = { 65, 66, 67, 97, 98, 99 }; // ASCII para 'A', 'B', 'C', 'a', 'b', 'c'
            ClaseArrayC Cant = new ClaseArrayC();
            string[] equivalenciaASCII = Cant.ObtenerEquivalenciaASCII(Us);

           Console.WriteLine("Equivalencia ASCII de los enteros:");
            foreach (string cadena in equivalenciaASCII)
           {
               Console.WriteLine(cadena);
           }

           Console.WriteLine("-----------------------");
           /*11.- Invertir todos los valores de un array de cadenas, de forma que el ultimo ahora sea el
           primero, el penultimo el segundo y asi sucesivamente.*/
           string[] arrayCadenas = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
           string[] arrayCad = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
           ClaseArrayC iinvert = new ClaseArrayC();
           string[] arrayInvertido = iinvert.InvertirArray(arrayCadenas);

           Console.WriteLine("Array original:");
           foreach (string cadena in arrayCad)
           {
               Console.Write(cadena + " ");
           }

           Console.WriteLine("\nArray invertido:");
           foreach (string cadena in arrayInvertido)
           {
               Console.Write(cadena + " ");
           }
           
           Console.WriteLine("-----------------------");


           //12.- Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia B - A
           string[] array97 = { "Hola", "Mundo", "Programación", "C#" };
           string[] array98 = { "Mundo", "C#", "Python", "JavaScript" };

           ClaseArrayC diferent = new ClaseArrayC();

           string[] diferenciar = diferent.ObtenerDiferencias(array97, array98);
           Console.WriteLine("Diferencia B - A:");
           foreach (string elem in diferenciar)
           {
               Console.WriteLine(elem);
           }

  
        }
    }
}