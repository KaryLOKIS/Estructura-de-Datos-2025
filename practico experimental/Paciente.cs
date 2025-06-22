
public class Paciente
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public int Edad { get; set; }
    public string MotivoConsulta { get; set; }

    public Paciente (string nombre, string cedula, int edad, string motivo)
    {
        Nombre = nombre;
        Cedula = cedula;
        Edad = edad;
        MotivoConsulta = motivo;
    }
}
