Console.WriteLine("ingrese la cantidad de estudiantes a registrar: ");
int.TryParse(Console.ReadLine(), out int lim);
Console.WriteLine(lim);
List<Estudiante>estudiantes = new List<Estudiante>();
if (lim > 0)
{
    for (int i = 0; i < lim; i++)
    {
        Estudiante e = new Estudiante();
        Console.WriteLine("ingrese nombre: "); e.nombre = Console.ReadLine();
        Console.WriteLine("ingrese nota1: "); e.nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese nota2: "); e.nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese nota3: "); e.nota3 = int.Parse(Console.ReadLine());
        estudiantes.Add(e);
    }
    double sumapromedio = 0;
    Estudiante mejor = estudiantes[0];
    foreach (Estudiante e in estudiantes)
    {
        e.Mostrar();
        sumapromedio += e.CalcularPromedio();
        if (mejor.CalcularPromedio()<e.CalcularPromedio())
        {
            mejor = e;
        }
    }
    Console.WriteLine($"el promedio total es: {sumapromedio/estudiantes.Count}");
    Console.WriteLine("mejor estudiante es: ");
    mejor.Mostrar();
}
else
{
    Console.WriteLine("ingrese valor valido");
}

class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double CalcularPromedio()
    {  return (nota1+nota2+nota3)/3; }
    public string Estado()
    {
        if (CalcularPromedio() >= 61) { return "aprobado"; }
        else { return "reprobado"; }
    }
    public void Mostrar()
    {
        Console.WriteLine($"nombre: {nombre} | estado: {Estado()} | promedio: {CalcularPromedio()}");
    }
}
