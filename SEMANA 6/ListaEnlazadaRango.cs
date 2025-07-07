System.Console.WriteLine("universiada estatal Amazoniza");
System.Console.WriteLine("semana 6");
System.Console.WriteLine("lista enlazada");
class ListaEnlazadaRango
{
    static void Main()
    {
        // Crear la lista enlazada
        System.Collections.Generic.LinkedList<int> lista = new System.Collections.Generic.LinkedList<int>();
        System.Random random = new System.Random();

        // Llenar la lista con 50 números aleatorios del 1 al 999
        for (int i = 0; i < 50; i++)
        {
            lista.AddLast(random.Next(1, 1000));
        }

        System.Console.WriteLine("Lista original:");
        MostrarLista(lista);

        // Leer los valores mínimo y máximo desde el teclado
        System.Console.Write("\nIngrese el valor mínimo del rango: ");
        int min = int.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(System.Console.ReadLine());

        // Eliminar nodos fuera del rango
        EliminarFueraDeRango(lista, min, max);

        System.Console.WriteLine("\nLista después de eliminar los valores fuera del rango:");
        MostrarLista(lista);
    }

    static void MostrarLista(System.Collections.Generic.LinkedList<int> lista)
    {
        foreach (int num in lista)
        {
            System.Console.Write(num + " ");
        }
        System.Console.WriteLine();
    }

    static void EliminarFueraDeRango(System.Collections.Generic.LinkedList<int> lista, int min, int max)
    {
        var nodo = lista.First;
        while (nodo != null)
        {
            var siguiente = nodo.Next;
            if (nodo.Value < min || nodo.Value > max)
            {
                lista.Remove(nodo);
            }
            nodo = siguiente;
        }
    }
}
