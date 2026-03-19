
Dictionary<int, Estudiante> estudiantes = new Dictionary<int, Estudiante>();
bool validar
class Estudiante
{
    public string nombre;
    public string carrera;
    public double nota;
    public string Estado() { return nota >= 61 ? "aprobado" : "reprobado"; }
    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {nombre} | Carrera: {carrera}| nota: {nota}"); 
    }
}
