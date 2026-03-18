using System.Security.Cryptography;


List<Ventas> venta = new List<Ventas>();
bool validar=false;
while (validar!= true)
{
    Console.WriteLine("ingrese cantidad de Ventas: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if(lim > 0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {
            Ventas v = new Ventas();
            Console.WriteLine($"producto No.{i+1}: ");v.producto = Console.ReadLine();
            Console.WriteLine("precio: ");v.precio= double.Parse(Console.ReadLine());
            Console.WriteLine("cantidad: ");v.cantidad= double.Parse(Console.ReadLine());
            venta.Add(v);
        }
        double totalventas = 0;
        foreach (Ventas v in venta)
        {
            v.Mostrar();
            totalventas += v.Total();
        }
        Console.WriteLine("total de ventas es: "+totalventas);
    }
    else
    {
        Console.WriteLine("ingresar valor valido");
    }
    
}
class Ventas ()
{
    public string producto;
    public double precio;
    public double cantidad;
    public double Subtotal() { return cantidad * precio; }
    public double Descuento() { if (Subtotal() > 500) { return Subtotal() * 0.05; }
        else if (Subtotal() > 1000) { return Subtotal() * 0.10; }
        else { return 0; }
    }
    public double Total() { return Subtotal() - Descuento(); }
    public void Mostrar()
    {
        Console.WriteLine($"Venta de: {producto} | subtotal: {Subtotal()} | Descuento: {Descuento()} | total: {Total()}");
    }
}
