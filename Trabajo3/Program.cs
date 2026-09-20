Alumno alumno1 = new Alumno("Ana", 1234, 7, 8);
Alumno alumno2 = new Alumno("Juan", 5678, 4, 5);

Console.WriteLine(alumno1.Nombre + " - Promedio: " + alumno1.Promedio());
Console.WriteLine(alumno2.Nombre + " - Promedio: " + alumno2.Promedio());

Console.WriteLine(alumno1.EstaAprobado());
Console.WriteLine(alumno2.EstaAprobado());

alumno2.SubirNota();

Console.WriteLine("Nuevo promedio de Juan: " + alumno2.Promedio());