
namespace tareas;

public class Tarea
{
    private int tareaID;
    private string? descripcion;
    private int duracion;

    public int Duracion { get => duracion; set => duracion = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int TareaID { get => tareaID; set => tareaID = value; }

}

/*
//No borrar dentro de un for
//Las dos listas siguen apuntano a los mismos archivos, cuando paso las pe
foreach ( item in realizadas) //Realizadas queda con dos 
{
    pendientes.Remove(item); 
}
*/