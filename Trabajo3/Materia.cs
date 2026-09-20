public class Materia : IExportable
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public int CantidadHoras { get; set; }

    public Materia(string codigo, string nombre, int cantidadHoras)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadHoras = cantidadHoras;
    }

    public string ExportarLinea()
    {
        return "MATERIA;" + Codigo + ";" + Nombre + ";" + CantidadHoras;
    }
}