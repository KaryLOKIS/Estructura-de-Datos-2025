System.Console.WriteLine("Universidad Estatal Amazonica");
System.Console.WriteLine("Ejercicio 2");

class Ejercicio2
{
    static void Main(string[] args)

    {
        system.Collections.Generic.list<string> asignaturas = new System.Collections.Generic.list<string>();

        asignaturas.Add("Matematicas");
        asignaturas.Add("Fisica");
        asignaturas.Add("Quimica");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua y Literatura");

        System.Console.WriteLine("Asignaturas del curso:");

        for (int i = 0; i < asignaturas.Count; i++)
        {
            System.Console.WriteLine("-" + asignaturas[i]);
        }


    }
}