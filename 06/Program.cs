
Dictionary<int, Estudiante> estudiantes = new Dictionary<int, Estudiante>();
int carnet;
bool validar= false;
while (validar!= true)
{
    Console.WriteLine("escriba la cantidad de estudiantes a Registrar: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim > 0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {               
            Console.WriteLine(" ingrese carnet: ");
            int.TryParse(Console.ReadLine(), out carnet);
            if (carnet > 0 && estudiantes.ContainsKey(carnet))
            {
                Console.WriteLine("valor invalido o ya ingresado");
            }
            else
            {


            }
        }
    }
    else
    {
        Console.WriteLine("OMG ingrese valor valido ");
    }

}
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
