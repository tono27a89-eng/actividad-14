bool validar = false;
List<Empleado> empleados = new List<Empleado>();
while (validar != true)
{
    Console.WriteLine("escriba la cantidad de empleados a Registrar:");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim > 0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {
            Empleado e=new Empleado();
            Console.WriteLine("ingrese nombre: ");e.nombre = Console.ReadLine();
            Console.WriteLine("ingrese puesto: ");e.puesto = Console.ReadLine();
            Console.WriteLine("ingrese salario: ");e.salario= double.Parse(Console.ReadLine());
            empleados.Add(e);            
        }
        foreach (Empleado e in empleados) 
        {
            Console.WriteLine($"empleado: {e.nombre} | puesto: {e.puesto} | salario anual: {e.SalarioAnual()+e.Bono()}"); 
        }
    }
    else
    {
        Console.WriteLine("ingrese valor valido");
    }
}
class Empleado()
{
    public string nombre;
    public string puesto;
    public double salario;
    public double SalarioAnual() { return salario * 12; }
    public double Bono() { if (salario > 4500) { return salario * 0.10; }
        else { return salario * 0.12; } }
    public string Estado()
    {
        if (salario > 4500) { return "salario medio"; }
        else if (salario > 7500) { return "salario Alto"; } else { return "salario bajo"; }
    }
}