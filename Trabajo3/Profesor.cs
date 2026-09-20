public class Profesor : Persona
{
    public string Materia { get; set; }

    public Profesor(string nombre, int documento, string materia)
        : base(nombre, documento)
    {
        Materia = materia;
    }
}