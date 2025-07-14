Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("SEMANA 7 PILAS");


class PilaBalanceo
{
    // Nodo para la pila
    class Nodo
    {
        public char valor;
        public Nodo siguiente;

        public Nodo(char v)
        {
            valor = v;
            siguiente = null;
        }
    }

    // Implementación manual de la pila
    class Pila
    {
        private Nodo cima;

        public Pila()
        {
            cima = null;
        }

        // Agrega un elemento a la pila
        public void Push(char c)
        {
            Nodo nuevo = new Nodo(c);
            nuevo.siguiente = cima;
            cima = nuevo;
        }

        // Elimina y devuelve el elemento del tope
        public char Pop()
        {
            if (EstaVacia())
            {
                return '\0'; // Retorna carácter nulo si está vacía
            }
            char dato = cima.valor;
            cima = cima.siguiente;
            return dato;
        }

        // Devuelve el elemento del tope sin eliminarlo
        public char Peek()
        {
            if (EstaVacia())
            {
                return '\0';
            }
            return cima.valor;
        }

        // Verifica si la pila está vacía
        public bool EstaVacia()
        {
            return cima == null;
        }
    }

    // Función que verifica si la fórmula está balanceada
    static bool EstaBalanceado(string expresion)
    {
        Pila pila = new Pila();

        for (int i = 0; i < expresion.Length; i++)
        {
            char c = expresion[i];

            // Si es símbolo de apertura, lo apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre, se compara con la cima
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.EstaVacia())
                    return false;

                char tope = pila.Pop();

                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    return false;
                }
            }
        }

        // Si al final la pila está vacía, está balanceado
        return pila.EstaVacia();
    }

    // Método principal para probar
    static void Main()
    {
        string formula = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        bool resultado = EstaBalanceado(formula);

        if (resultado)
        {
            System.Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            System.Console.WriteLine("Fórmula no balanceada.");
        }
    }
}
