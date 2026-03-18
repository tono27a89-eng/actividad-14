using System.ComponentModel;
Console.WriteLine("ingrese la cantidad de productos a Registrar: ");
int.TryParse(Console.ReadLine(), out int lim);
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
