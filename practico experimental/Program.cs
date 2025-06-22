// See https://aka.ms/new-console-template for more information
Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("Practico Experimental 1");

System.Console.WriteLine("Agenda de turnos de Pacientes");

int max = 10;

Paciente[] agenda = new Paciente[max];

Paciente paciente1 = new Paciente("maria perez", "0102030405", 35, "chequeo general");
Paciente paciente2 = new Paciente("carlos torres", "0607080910", 28, "dolor de cabeza");
Paciente paciente3 = new Paciente("ana leon", "0708097011", 40, "consulta ginecologica");

agenda[0] = paciente1;
agenda[1] = paciente2;
agenda[2] = paciente3;

bool continuar = true;
int i = 0;

System.Console.WriteLine("\nLista de Turnos:");
while (continuar)
{
    if (agenda[i] != null)
    {
        System.Console.WriteLine("Nombre: " + agenda[i].Nombre + "cedula: " + agenda[i].Cedula + "Edad: " + agenda[i].Edad + "Motivo: " + agenda[i].MotivoConsulta);

        i++;
    }
    else
    {
        continuar = false;
    }
}

continuar = true;
bool encontrado = false;
i = 0;
string consulta = "maria perez";

while (continuar)
{
    if (agenda[i] != null)
    {
        if (agenda[i].Nombre == consulta)
        {
            encontrado = true;
        }
        i++;
    }
    else
    {
        continuar = false;
    }
}

if (encontrado == true)
{
    System.Console.WriteLine("\nEl registro ha sido encontrado.");
}
else
{
    System.Console.WriteLine("\nEl registro no existe.");
}
