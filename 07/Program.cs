Dictionary<int, Producto> producto = new Dictionary<int, Producto>();
bool validar = false;
int codigo;
while (validar != true)
{
    Console.WriteLine("ingrese la cantidad de productos a Registrar: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim > 0)
    {
        validar = true;
        Console.WriteLine("ingrese codigo: ");
        int.TryParse(Console.ReadLine(), out codigo);
        if (codigo <= 0 || producto.ContainsKey(codigo))
        {

        }
    }
    else { Console.WriteLine("ingrese valor valido"); }
}

class Producto
{
    public string nombre;
    public double precio;
    public double stock;
    public string Estado()
    {
        if (stock < 10)
        {
            return "agotado";
        }
        else if (stock < 100) { return "bajo"; }
        else { return "normal"; }
    }
    public void Mostrar()
    {
        Console.WriteLine($"nombre: {nombre} | precio: {precio} Stock: {stock} |estado: {Estado()}");
    }
}