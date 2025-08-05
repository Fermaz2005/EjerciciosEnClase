using clases;

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante();
        estudiante.Nombre = "Ana";
        estudiante.Saludar();
        estudiante.Estudiar();

        Profesor profesor = new Profesor();
        profesor.Nombre = "Carlos";
        profesor.Saludar();
        profesor.Enseñar();
    }
}