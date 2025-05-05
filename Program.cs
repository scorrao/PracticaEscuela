Console.WriteLine("Sistema de gestion de escuelas");

List<Escuela> escuelas = new List<Escuela>();
Escuela nuevaEscuela;
do
{
    nuevaEscuela = CargarEscuela();
    if (nuevaEscuela != null)
        escuelas.Add(nuevaEscuela);
} while (nuevaEscuela != null);

Console.WriteLine("Pulse una tecla para continuar");
Console.ReadKey();

MostrarDatos(escuelas);
//__________________________________________________

void MostrarDatos(List<Escuela> escuelas)
{
    foreach (Escuela escuela in escuelas)
    {
        Console.WriteLine($"{escuela.Nombre} - {escuela.Ciudad}");
        foreach(Curso curso in escuela.Cursos)
        {
            Console.WriteLine($"    {curso.Nombre}");
            Console.WriteLine($"        {curso.Profesor.Nombre} - {curso.Profesor.Apellido} - {curso.Profesor.Titulo} - {curso.Profesor.Sueldo}");
            foreach (Alumno alumno in curso.Alumnos)
            {
                Console.WriteLine($"        {alumno.Nombre} - {alumno.Apellido} - {alumno.Anio}");
                
            }
        }
    }
}

Escuela? CargarEscuela()
{
    Escuela escuela = new();
    Console.WriteLine("Ingrese el nombre de la escuela");
    escuela.Nombre = Console.ReadLine();
    if (!string.IsNullOrEmpty(escuela.Nombre))
    {
        Console.WriteLine("Ingrese la ciudad de la escuela");
        escuela.Ciudad = Console.ReadLine();
        Curso nuevoCurso;
        do
        {
            nuevoCurso = CargarCurso();
            if (nuevoCurso != null)
                escuela.Cursos.Add(nuevoCurso);
        } while (nuevoCurso != null);
        return escuela;
    }
    else
        return null;
}

Curso? CargarCurso()
{
    Curso curso = new();
    Console.WriteLine("Ingrese el nombre del curso");
    curso.Nombre = Console.ReadLine();
    if (!string.IsNullOrEmpty(curso.Nombre))
    {
        Console.WriteLine("Ingrese los datos del profesor");
        curso.Profesor = CargarProfesor();
        Alumno nuevoAlumno;
        do
        {
            nuevoAlumno = CargarAlumno();
            if (nuevoAlumno != null)
                curso.Alumnos.Add(nuevoAlumno);
        } while (nuevoAlumno != null);
        return curso;
    }
    else
        return null;
}

Profesor CargarProfesor()
{
    Profesor profesor = new();
    Console.WriteLine("Ingrese el nombre del profesor:");
    profesor.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el Apellido del profesor:");
    profesor.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese el Titulo del profesor:");
    profesor.Titulo = Console.ReadLine();
    Console.WriteLine("Ingrese el sueldo del profesor:");
    profesor.Sueldo = float.Parse(Console.ReadLine());
    return profesor;
}

Alumno? CargarAlumno()
{
    Alumno alumno = new();
    Console.WriteLine("Ingrese el nombre del alumno:");
    alumno.Nombre = Console.ReadLine();
    if (!string.IsNullOrEmpty(alumno.Nombre))
    {
        Console.WriteLine("Ingrese el Apellido del alumno:");
        alumno.Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese el Anio del alumno:");
        alumno.Anio = Console.ReadLine();
        return alumno;
    }
    else
        return null;
}

