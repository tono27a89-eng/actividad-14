Dictionary<int, Cuenta> cuentas = new Dictionary<int, Cuenta>();



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