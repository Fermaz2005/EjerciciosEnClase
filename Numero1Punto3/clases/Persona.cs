namespace clases
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre}.");
        }
    }
}