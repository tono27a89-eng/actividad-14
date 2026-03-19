using System.ComponentModel.Design;

Dictionary<int, Cuenta> cuentas = new Dictionary<int, Cuenta>();
bool validar=false;
int cuenta;
while (validar!= true)
{
    Console.WriteLine("ingrese la cantidad de cuentas a registrar: ");
    int.TryParse(Console.ReadLine(), out int lim);
    if (lim > 0)
    {
        validar = true;
        for (int i = 0; i < lim; i++)
        {
            Console.WriteLine("ingrese numero de cuenta: ");
            int.TryParse(Console.ReadLine(), out cuenta);
            if (cuenta <= 0 || cuentas.ContainsKey(cuenta))
            { Console.WriteLine("valor invalido"); }
            else
            {
                Cuenta c = new Cuenta();
                Console.WriteLine("ingrese nombre de titular: ");c.titular = Console.ReadLine();
                Console.WriteLine(" ingrese saldo: ");c.saldo= double.Parse(Console.ReadLine());
                cuentas[cuenta]= c;
            }
        }
        bool validar2= false;
        while (validar2 != true)
        {
            Console.WriteLine("ingrese numero de cuenta a que desea depositar: ");
            int.TryParse(Console.ReadLine(), out cuenta);
            if (cuenta > 0 && cuentas.ContainsKey(cuenta))
            {
                validar2 = true;
                Console.WriteLine("ingrese monto: ");
                double.TryParse(Console.ReadLine(), out double depo);
                cuentas[cuenta].Depositar(depo);
            }
            else { Console.WriteLine("cuenta no encontrada"); }
        }
      }
    else { Console.WriteLine("valor invalido"); }
    bool validar3 = false;
    while (validar3!= true)
    {
        Console.WriteLine("ingrese No. de cuenta que desea retirar: ");
        int.TryParse (Console.ReadLine(), out cuenta);
        if(cuenta > 0 &&cuentas.ContainsKey(cuenta))
        { Console.WriteLine("ingrese monto a retirar: ");
        double.TryParse (Console.ReadLine(), out double retiro);
            cuentas[cuenta].retirar(retiro);
            validar3 = true;
        }
        else
        {
            Console.WriteLine("cuenta no encontrada");
        }
    }
    foreach (KeyValuePair<int,Cuenta> item in cuentas)
    {
        Console.WriteLine($"No. de cuenta:{item.Key} ");item.Value.Mostrar();
    }
}


class Cuenta
{
    public string titular;
    public double saldo;
    public void Depositar(double monto) {   saldo+= monto; }
    public bool retirar(double monto) { if (monto <= saldo) { saldo -= monto;return true; } return false; }
public void Mostrar()
    {
        Console.WriteLine($"titular: {titular} | saldo: {saldo} ");
    }
}