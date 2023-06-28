// See https://aka.ms/new-console-template for more information
using System.IO;
using tareas;

internal class Program
{
    private static void Main(string[] args) 
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();

        string?[] descripcion = {"Preparar informes", "Preparar Documentacion", "Programar tareas"};

        for (int N = 0; N < 3; N++)
        {
            Tarea nuevaTarea = new Tarea();
            nuevaTarea.Descripcion = descripcion[N];
            nuevaTarea.Duracion = N+3;
            nuevaTarea.TareaID = N + 1;
            tareasPendientes.Add(nuevaTarea);
        }

        string? resp = "", tareaBuscar="";

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


        GuardarArchivo(tareasPendientes);

        Console.WriteLine("\nBuscar tarea... (SI:S NO:N) ");
        resp = Console.ReadLine();
        if (resp == "S")
        {
            Console.WriteLine("Ingrese la descripcion de la tarea a buscar:");
            tareaBuscar = Console.ReadLine();
            foreach (var Tarea in tareasPendientes)
            {
                if (tareaBuscar == Tarea.Descripcion)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Informacion de tarea:");
                    Console.WriteLine("ID: " + Tarea.TareaID);
                    Console.WriteLine("Descripción: " + Tarea.Descripcion);
                    Console.WriteLine("Duración: " + Tarea.Duracion);
                } 

            }

        } else {
                Console.WriteLine("FIN");
        }

        

    }

    private static void GuardarArchivo(List<Tarea> tareas)
    {
        int suma = 0;
        string? ruta = @"C:\Users\yazmi\tpTaller\tl1_tp8_2023-yazmoyano23\";

        foreach (var tarea in tareas)
        {
            suma += tarea.Duracion;
        }

        StreamWriter escribe = new StreamWriter(ruta + "cantidadhorastrabajadas", true);
        escribe.WriteLine("Horas trabajadas: " + suma);
        escribe.Close();
    }
}


