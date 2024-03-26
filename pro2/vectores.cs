
    public class Vectores
    {

        public static void ejercicio1()
        {
            string[] element = Console.ReadLine().Split();
            int suma = 0;
            foreach(string elemento in element)
            {
                if (int.TryParse(elemento, out int yt))
                {
                    if ((yt % 2) == 0)
                    {
                        suma++;
                    }
                }
        
            }
            Console.WriteLine("hay " + suma + " vectores pares");
        }

    }

    





    
