
using System.Security.Cryptography;

List<Libro> libros = new List<Libro>();
bool validar=false;
while (validar != true)
{
    Console.WriteLine("ingrese la cantidad de libros a Registrar: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim>0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {
            Libro l = new Libro();
            Console.WriteLine("ingrese titulo: ");l.titulo = Console.ReadLine();
            Console.WriteLine("ingrese autor: ");l.autor = Console.ReadLine();
            Console.WriteLine("ingrese categoria: ");l.categoria = Console.ReadLine();
            Console.WriteLine("ingrese numero de paginas: ");l.paginas=int.Parse(Console.ReadLine());
            libros.Add(l);
        }
        Libro mayor = libros[0];
        foreach (Libro l in libros)
        {
            l.Mostrar();
            if (l.paginas> mayor.paginas) {mayor=l; }
        }
        Console.WriteLine("el libro con mayor paginas es: "+mayor.titulo);
        mayor.Mostrar();
    }
    else
    {
        Console.WriteLine("ingrese valor valido");
    }
}


class Libro()
{
    public string titulo;
    public string autor;
    public string categoria;
    public int paginas;
    public string Clasificar()
    {
        if (paginas < 300) { return "novela ligera"; }
        else if (paginas < 450) { return "novela"; }
        else { return "libro o novela larga"; }
    }
    public void Mostrar()
    {
        Console.WriteLine($"titulo: {titulo}| autor: {autor}| categoria: {categoria} | paginas: {paginas}| tipo:{Clasificar()}");
    }
}
