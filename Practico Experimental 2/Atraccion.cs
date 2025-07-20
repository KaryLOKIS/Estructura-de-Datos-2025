Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("Practico Experimetnal 2 ");

public class Atraccion
{
    public static void run()
    {
        Queue<string> cola = new Queue<string>();
        List<string> asientos = new List<string>();

        // Simulamos 35 personas llegando
        for (int i = 1; i <= 35; i++)
        {
            cola.Enqueue("Persona" + i);
        }

        System.Console.WriteLine("Cola inicial:");
        imprimirCola(cola);

        // Asignamos los 30 primeros a los asientos
        for (int i = 0; i < 30; i++)
        {
            string persona = cola.Dequeue();
            asientos.Add(persona);
            System.Console.WriteLine("Asiento asignado a: " + persona);
        }

        System.Console.WriteLine();
        System.Console.WriteLine(" Todos los asientos han sido asignados.\n");

        // Mostrar resultados
        System.Console.WriteLine("Personas que subieron a la atracción:");
        imprimirLista(asientos);

        System.Console.WriteLine("\n Personas que quedaron en cola:");
        imprimirCola(cola);

        cantidadElementos(asientos, cola);
    }

    public static void imprimirCola(Queue<string> cola)
    {
        foreach (var persona in cola)
        {
            System.Console.WriteLine(persona);
        }
    }

    public static void imprimirLista(List<string> lista)
    {
        foreach (var persona in lista)
        {
            System.Console.WriteLine(persona);
        }
    }

    public static void cantidadElementos(List<string> asientos, Queue<string> cola)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Total de personas con asiento: " + asientos.Count);
        System.Console.WriteLine("Personas aún en espera: " + cola.Count);
    }
}
