bool validar = false;
while (validar != true)
{
    Console.WriteLine("escriba la cantidad de empleados a Registrar:");
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