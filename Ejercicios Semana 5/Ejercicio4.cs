System.Console.WriteLine("Universidad Estatal Amazonica");
System.Console.WriteLine("Ejercicio 3");

class Ejercicio4
{
    static void Main(string[] args)
    {
        Abecedario abecedario = new Abecedario();
        abecedario.EliminarMultiplosDeTres();
        abecedario.Mostrar();
    }
}

class Abecedario
{
    private System.Collections.Generic.List<char> letras;

    public Abecedario()
    {
        letras = new System.Collections.Generic.List<char>();
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            letras.Add(letra);
        }
    }

    public void EliminarMultiplosDeTres()
    {
        System.Collections.Generic.List<int> posicionesAEliminar = new System.Collections.Generic.List<int>();

        for (int i = 0; i < letras.Count; i++)
        {
            if ((i + 1) % 3 == 0) // Posiciones 3, 6, 9... (1-based)
            {
                posicionesAEliminar.Add(i);
            }
        }

        // Eliminamos desde el final para no alterar los índices
        for (int j = posicionesAEliminar.Count - 1; j >= 0; j--)
        {
            letras.RemoveAt(posicionesAEliminar[j]);
        }
    }

    public void Mostrar()
    {
        System.Console.WriteLine("Letras restantes (sin posiciones múltiplos de 3):");
        for (int i = 0; i < letras.Count; i++)
        {
            System.Console.Write(letras[i] + " ");
        }
        System.Console.WriteLine(); // salto de línea final
    }
}

