List<Alumno> alumnos = new List<Alumno>();

int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("=== SISTEMA DE ALUMNOS ===");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Mostrar promedio general");
    Console.WriteLine("5. Mostrar cantidad de aprobados");
    Console.WriteLine("6. Salir");

    Console.Write("Elegí una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(nombre, legajo);

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            bool cargadas = nuevoAlumno.CargarNotas(nota1, nota2);

            if (cargadas)
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Las notas son inválidas.");
            }

            break;

        case 2:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados.");
            }
            else
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }

            break;

        case 3:
            Console.Write("Ingresá el legajo a buscar: ");
            int legajoBuscado = int.Parse(Console.ReadLine());

            Alumno encontrado = null;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == legajoBuscado)
                {
                    encontrado = alumno;
                }
            }

            if (encontrado != null)
            {
                Console.WriteLine(encontrado);
            }
            else
            {
                Console.WriteLine("No existe un alumno con ese legajo.");
            }

            break;

        case 4:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados.");
            }
            else
            {
                double sumaPromedios = 0;

                foreach (Alumno alumno in alumnos)
                {
                    sumaPromedios += alumno.Promedio();
                }

                double promedioGeneral = sumaPromedios / alumnos.Count;

                Console.WriteLine("Promedio general: " + promedioGeneral);
            }

            break;

        case 5:
            int cantidadAprobados = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.EstaAprobado())
                {
                    cantidadAprobados++;
                }
            }

            Console.WriteLine("Cantidad de aprobados: " + cantidadAprobados);

            break;

        case 6:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 6);