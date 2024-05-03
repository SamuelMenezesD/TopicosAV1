public class ContaEmpresarial : ContaBancaria
{
    public double saldomi { get; set; }

     public ContaEmpresarial(int idConta, double saldoMi) : base(idConta)
    {
        saldomi = saldoMi;
    }
    public override void Sacar(double valor)
    {
        if (valor <= saldo - saldomi)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ");
        }
    }

    public override void MostrarSaldo()
    {
        Console.WriteLine($"Conta Empresarial numero: {idconta} - saldo: {saldo}");
    }
}