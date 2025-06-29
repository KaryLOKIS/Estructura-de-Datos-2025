
System.Console.WriteLine("Universidad Estatal Amazonica");
System.Console.WriteLine("Ejercicio 5");
class Ejercicio5
{
    static void Main(string[] args)
    {
        ListaPrecios lista = new ListaPrecios();
        lista.MostrarMayorYMenor();
    }
}

class ListaPrecios
{
    private System.Collections.Generic.List<int> precios;

    public ListaPrecios()
    {
        precios = new System.Collections.Generic.List<int>();
        precios.Add(50);
        precios.Add(75);
        precios.Add(46);
        precios.Add(22);
        precios.Add(80);
        precios.Add(65);
        precios.Add(8);
    }

    public void MostrarMayorYMenor()
    {
        int menor = precios[0];
        int mayor = precios[0];

        for (int i = 1; i < precios.Count; i++)
        {
            if (precios[i] < menor)
            {
                menor = precios[i];
            }
            if (precios[i] > mayor)
            {
                mayor = precios[i];
            }
        }

        System.Console.WriteLine("El precio menor es: " + menor);
        System.Console.WriteLine("El precio mayor es: " + mayor);
    }
}

