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
        Console.WriteLine("ingrese numero de cuenta a que desea depositar: ");
        int.TryParse(Console.ReadLine(), out cuenta);
        if(cuenta > 0&& cuentas.ContainsKey(cuenta))
        {
            Console.WriteLine("ingrese monto: ");
            double.TryParse(Console.ReadLine(), out double depo);
            cuentas[cuenta].Depositar(depo);
        }
        else { Console.WriteLine("cuenta no encontrada"); }
    }
    else { Console.WriteLine("valor invalido"); }
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