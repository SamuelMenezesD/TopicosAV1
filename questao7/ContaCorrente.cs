public class ContaCorrente : ContaBancaria{

    public ContaCorrente(int idConta) : base(idConta)
    {
    }
    public override void MostrarSaldo()
    {
        Console.WriteLine($"Conta Corrente numero: {idconta} saldo: R${saldo}");
    }
}