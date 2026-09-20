public class Preceptor : Persona
{
    public Preceptor(string nombre, int documento)
        : base(nombre, documento)
    {
    }

    public override string Presentarse()
    {
        return "Hola, soy " + Nombre + " y soy preceptor.";
    }
}