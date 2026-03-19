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
        for (int i = 0; i < lim; i++)
        {
            Console.WriteLine("ingrese codigo: ");
            int.TryParse(Console.ReadLine(), out codigo);
            if (codigo <= 0 || producto.ContainsKey(codigo))
            {
                Console.WriteLine(" codigo invalido. ");
                i--;
            }
            else
            {
                Producto p = new Producto();
                Console.WriteLine("ingrese nombre: ");p.nombre = Console.ReadLine();
                Console.WriteLine("ingrese precio: ");p.precio = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese stock: ");p.stock = double.Parse(Console.ReadLine());
                producto.Add(codigo, p);
            }
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