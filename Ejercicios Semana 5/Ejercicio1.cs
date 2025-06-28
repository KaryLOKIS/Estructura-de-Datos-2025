
System.Console.WriteLine("Universidad Estatal Amazonica");
System.Console.WriteLine("Ejercicio 1");
class Ejercicio1
{
    static void Main(string[] args)
    {
        System.Console.Write("Introduce una palabra: ");
        string entrada = System.Console.ReadLine().ToLower();

        char[] original = entrada.ToCharArray();
        char[] invertida = entrada.ToCharArray();
        System.Array.Reverse(invertida);

        bool esPalindromo = true;
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] != invertida[i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            System.Console.WriteLine("Es un palíndromo");
        }
        else
        {
            System.Console.WriteLine("No es un palíndromo");
        }
    }
}
