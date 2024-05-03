public class TransferenciaBancaria : IMetodoPagamento
{
    public bool RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor}");
        return true;
    }

    public string VerificarStatus()
    {
        return "Pagamento confirmado";
    }
}