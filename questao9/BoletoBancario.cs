public class BoletoBancario : IMetodoPagamento
{
    public bool RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de {valor} realizado");
        return true;
    }

    public string VerificarStatus()
    {
        return "Pagamento confirmado";
    }
}