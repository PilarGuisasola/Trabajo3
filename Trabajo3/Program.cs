Alumno alumno1 = new Alumno("Ana Pérez", 1234);

bool cargadas = alumno1.CargarNotas(7, 8);

if (!cargadas)
{
    Console.WriteLine("Las notas son inválidas.");
}

Console.WriteLine(alumno1);
