
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
            if (carnet <= 0 || estudiantes.ContainsKey(carnet))
            {
                Console.WriteLine("valor invalido o ya ingresado");
                i--;
            }
            else
            {
                Estudiante e = new Estudiante();
                Console.WriteLine("ingrese nombre: ");e.nombre = Console.ReadLine();
                Console.WriteLine("ingrese carrera: ");e.carrera = Console.ReadLine();
                Console.WriteLine("ingrese nota final: ");e.nota= double.Parse(Console.ReadLine());
                estudiantes[carnet] = e;

            }
        }
        foreach ( KeyValuePair<int,Estudiante> item in estudiantes)
        {
            Console.WriteLine($"Carnet: {item.Key} |" ); item.Value.Mostrar();
        }
        bool validar2= false;
        while (validar2 != true)
        {
            Console.WriteLine("ingrese carnet a buscar: ");
            int.TryParse(Console.ReadLine(), out int buscar);
            if (buscar > 0 && estudiantes.ContainsKey(buscar))
            {validar2=true;
                Console.WriteLine("carnet encontrado: ");
                estudiantes[buscar].Mostrar();
            }
            else
            {
                Console.WriteLine("carnet invalido");
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
