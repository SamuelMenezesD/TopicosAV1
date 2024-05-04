public class BoletoBancario : IMetodoPagamento{
    public double Valor {get; set;}
    public string status {get; set;}
    public BoletoBancario (double valor){
        this.Valor = valor;
        this.status = "Pendente";
    }
    public void RealizarPagamento()
    {
        status = "Pago";
        Console.WriteLine($"Pagamento de {Valor} realizado");
    }

    public void VerificarStatus()
    {
        Console.WriteLine ("Status do pagamento: " + status);
    }
}