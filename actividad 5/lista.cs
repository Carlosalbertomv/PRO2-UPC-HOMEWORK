public class Lista
{
    public string Grupo;
    public string Materia;
    //public string NombrePropietario;
    public string Docente;
    public string Periodo;
    public string Hora;


    public Lista()
    {
        Grupo = "";
        Materia = " ";
        Docente = "";
        Periodo = "";
        Hora = "";
    }

    public void DarNombre(string valor)
    {
        Grupo = valor;
    }

    public void DarNombr(string valor)
    {
        Materia = valor;
    }

    public string Mostrar(){
        return  "Grupo: " + Grupo + ", " +
        "Materia: " + Materia + ", " +
        "Docente: " + Docente + ", " +
        "Periodo: " + Periodo + ", " +
        "Hora: " + Hora + ", " ;
    }

}