public class ContaPoupanca : ContaBancaria
{
    public double juros { get;set; }

    public ContaPoupanca(int idConta, double Juros) : base(idConta)
    {
        juros = Juros;
    }
    public override void Depositar(double valor)
    {
        base.Depositar(valor);
        AplicarJuros();
    }

    private void AplicarJuros()
    {
        saldo += saldo * juros;
    }
     public override void MostrarSaldo()
    {
        Console.WriteLine($"Conta Poupança numero: {idconta} saldo: {saldo}");
    }
}