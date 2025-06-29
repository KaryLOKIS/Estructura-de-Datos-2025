System.Console.WriteLine("Universidad Estatal Amazonica");
System.Console.WriteLine("Ejercicio 3");

class Ejercicio3
{
    static void Main(string[] args)
    {
        Sorteo sorteo = new Sorteo();
        sorteo.PedirNumeros();
        sorteo.MostrarNumerosOrdenados();
    }
}

class Sorteo
{
    private System.Collections.Generic.List<int> numeros;

    public Sorteo()
    {
        numeros = new System.Collections.Generic.List<int>();
    }

    public void PedirNumeros()
    {
        System.Console.WriteLine("Ingrese 6 números ganadores de la lotería primitiva:");

        int contador = 1;
        while (numeros.Count < 6)
        {
            System.Console.Write("Número " + contador + ": ");
            string entrada = System.Console.ReadLine();

            bool exito = int.TryParse(entrada, out int numero);
            if (exito)
            {
                numeros.Add(numero);
                contador++;
            }
            else
            {
                System.Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
            }
        }
    }

    public void MostrarNumerosOrdenados()
    {
        numeros.Sort(); // Ordena de menor a mayor

        System.Console.WriteLine("Números ganadores ordenados:");
        for (int i = 0; i < numeros.Count; i++)
        {
            System.Console.WriteLine("- " + numeros[i]);
        }
    }
}

