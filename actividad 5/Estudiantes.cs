public class Estudiante{
    private int Nº;
    private string COD;
    private string Carrera;
    private int Fecha;
    public Estudiante(){
        Nº = 0;
        COD = "Sin Nombre";
        Carrera = "";
        Fecha = 0;

    }
    public Estudiante(int N, string codi, string carrera, int date){    
        Nº = N;
        COD = codi;
        Carrera = carrera;
        Fecha = date;
    }
    public string Mostrar(){
        return  "Nº: " + Nº + ", " +
        "COD: " + COD + ", " +
        "Carrera: " + Carrera + " ," +
        "Fecha: "  + Fecha + " ," ;
    }
}