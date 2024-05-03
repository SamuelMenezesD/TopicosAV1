
public class CartaoCredito : IMetodoPagamento
{
    public bool RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado");
        return true;
    }

    public string VerificarStatus()
    {
        return "Pagamento aprovado";
    }
}