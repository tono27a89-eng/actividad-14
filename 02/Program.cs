using System.ComponentModel;

bool validar= false;
List<Producto>productos=new List<Producto>();
while (validar != true)
{
    Console.WriteLine("ingrese la cantidad de productos a Registrar: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim > 0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {
           Producto P = new Producto();

        }

    }
    else
    {
        Console.WriteLine("ingrese valor valido"); validar = false;
    }
}
class Producto
{
    public string nombre;
    public double precio;
    public double cantidad;
    public double Valortotal() { return precio * cantidad; }
    public string Estado()
    {
        if (cantidad <= 10) { return "sin existencia"; }
        else if (cantidad > 10 && cantidad < 100) { return "stock bajo"; }
        else { return "stock suficiente"; }
    }
}
