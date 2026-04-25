using System;
using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        ArrayList tareas = new ArrayList();
        string opcion = "";

        while (opcion != "4")
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opcion: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                if (tareas.Count == 0)
                {
                    Console.WriteLine("No hay tareas.");
                }
                else
                {
                    for (int i = 0; i < tareas.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + tareas[i]);
                    }
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Escribe la tarea: ");
                string tarea = Console.ReadLine();
                tareas.Add(tarea);
                Console.WriteLine("Tarea agregada.");
            }
            else if (opcion == "3")
            {
                if (tareas.Count == 0)
                {
                    Console.WriteLine("No hay tareas para eliminar.");
                }
                else
                {
                    for (int i = 0; i < tareas.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + tareas[i]);
                    }
                    Console.Write("Elige el numero de la tarea a eliminar: ");
                    int numero = int.Parse(Console.ReadLine());
                    tareas.RemoveAt(numero - 1);
                    Console.WriteLine("Tarea eliminada.");
                }
            }
        }
    }
}