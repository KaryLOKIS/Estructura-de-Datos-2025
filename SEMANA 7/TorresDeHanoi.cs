Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("SEMANA 7 PILAS");


class TorresDeHanoi
{
    // Nodo de la pila
    class Nodo
    {
        public int valor;
        public Nodo siguiente;

        public Nodo(int v)
        {
            valor = v;
            siguiente = null;
        }
    }

    // Implementación manual de la pila
    class Pila
    {
        private Nodo cima;
        private string nombre;

        public Pila(string n)
        {
            cima = null;
            nombre = n;
        }

        // Agrega un disco a la torre
        public void Push(int v)
        {
            Nodo nuevo = new Nodo(v);
            nuevo.siguiente = cima;
            cima = nuevo;
        }

        // Quita y retorna el disco superior
        public int Pop()
        {
            if (EstaVacia()) return -1;
            int dato = cima.valor;
            cima = cima.siguiente;
            return dato;
        }

        // Muestra el nombre de la torre
        public string Nombre()
        {
            return nombre;
        }

        public bool EstaVacia()
        {
            return cima == null;
        }
    }

    // Muestra el movimiento de un disco entre torres
    static void MoverDisco(Pila origen, Pila destino)
    {
        int disco = origen.Pop();
        destino.Push(disco);
        System.Console.WriteLine("Mover disco " + disco + " desde " + origen.Nombre() + " hacia " + destino.Nombre());
    }

    // Método recursivo para resolver las Torres de Hanoi
    static void ResolverHanoi(int n, Pila origen, Pila auxiliar, Pila destino)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino);
        }
        else
        {
            ResolverHanoi(n - 1, origen, destino, auxiliar);
            MoverDisco(origen, destino);
            ResolverHanoi(n - 1, auxiliar, origen, destino);
        }
    }

    // Programa principal
    static void Main()
    {
        int numDiscos = 3; // Puedes cambiar este valor para más discos

        // Crear tres torres con nombres
        Pila torreA = new Pila("A");
        Pila torreB = new Pila("B");
        Pila torreC = new Pila("C");

        // Colocar discos en la torre A (del mayor al menor)
        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        // Resolver el problema
        System.Console.WriteLine("Movimientos para resolver Torres de Hanoi con " + numDiscos + " discos:\n");
        ResolverHanoi(numDiscos, torreA, torreB, torreC);
    }
}
