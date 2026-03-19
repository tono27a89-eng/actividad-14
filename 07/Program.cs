

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