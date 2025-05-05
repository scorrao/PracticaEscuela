public class Escuela
{
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public List<Curso> Cursos {get; set;} = new ();
}