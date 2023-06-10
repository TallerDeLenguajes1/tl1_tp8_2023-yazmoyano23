// See https://aka.ms/new-console-template for more information

using tareas;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

for (int N = 0; N < 5; N++)
{
    Tarea nuevaTarea = new Tarea();
    nuevaTarea.Descripcion = "Tarea " + (N+1);
    nuevaTarea.Duracion = N+5;
    nuevaTarea.TareaID = N + 1;
    tareasPendientes.Add(nuevaTarea);
}

string? resp = "";
foreach (var tarea in tareasPendientes)
{
    Console.WriteLine("¿Se realizó la tarea " + tarea.TareaID + ": " + tarea.Descripcion + "?");
    resp = Console.ReadLine();
    if (resp == "S")
    {
        tareasRealizadas.Add(tarea);
    }
}

foreach ( var tarea in tareasRealizadas) //Realizadas queda con dos 
{
    tareasPendientes.Remove(tarea); 
}

Console.WriteLine("\nTAREAS PENDIENTES");

foreach (var Tarea in tareasPendientes)
{
    Console.WriteLine("\nID: " + Tarea.TareaID);
    Console.WriteLine("Descripción: " + Tarea.Descripcion);
    Console.WriteLine("Duración: " + Tarea.Duracion);
}

Console.WriteLine("\nTAREAS REALIZADAS");

foreach (var Tarea in tareasRealizadas)
{
    Console.WriteLine("\nID: " + Tarea.TareaID);
    Console.WriteLine("Descripción: " + Tarea.Descripcion);
    Console.WriteLine("Duración: " + Tarea.Duracion);
}
