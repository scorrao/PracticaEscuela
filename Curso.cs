public class Curso{
    public string Nombre {get;set;}
    public Profesor Profesor {get;set;}
    public List<Alumno> Alumnos {get;set;} = new();
    public Escuela Escuela {get;set;}

    public void AsignarProfesor(Profesor profesor)
    {
        Profesor = profesor;
        profesor.Curso = this;
    }

    public void Inscribir(Alumno alumno)
    {
        Alumnos.Add(alumno);
        alumno.Curso = this;
    }
}