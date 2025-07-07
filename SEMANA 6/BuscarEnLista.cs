System.Console.WriteLine("universidad Estatal Amazonica");
System.Console.WriteLine("Busqueda en Lista");
class BuscarEnLista
{
    static void Main()
    {
        // Crear la lista enlazada
        System.Collections.Generic.LinkedList<int> lista = new System.Collections.Generic.LinkedList<int>();

        // Agregar elementos manualmente o aleatoriamente
        lista.AddLast(10);
        lista.AddLast(25);
        lista.AddLast(10);
        lista.AddLast(40);
        lista.AddLast(25);
        lista.AddLast(50);
        lista.AddLast(10);

        // Mostrar la lista
        System.Console.WriteLine("Elementos en la lista:");
        foreach (int num in lista)
        {
            System.Console.Write(num + " ");
        }

        // Leer el valor a buscar
        System.Console.Write("\n\nIngrese el valor que desea buscar en la lista: ");
        int valorBuscado = int.Parse(System.Console.ReadLine());

        // Buscar el valor
        int repeticiones = BuscarValor(lista, valorBuscado);

        // Mostrar resultado
        if (repeticiones > 0)
        {
            System.Console.WriteLine($"\nEl valor {valorBuscado} se encontró {repeticiones} veces en la lista.");
        }
        else
        {
            System.Console.WriteLine($"\nEl valor {valorBuscado} no fue encontrado en la lista.");
        }
    }

    static int BuscarValor(System.Collections.Generic.LinkedList<int> lista, int valor)
    {
        int contador = 0;

        foreach (int num in lista)
        {
            if (num == valor)
            {
                contador++;
            }
        }

        return contador;
    }
}

