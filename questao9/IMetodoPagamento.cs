public interface IMetodoPagamento
{
    bool RealizarPagamento(double valor);
    string VerificarStatus();
}
