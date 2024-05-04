public class Caixa{
    public void RealizarPagamento(IMetodoPagamento pagamento){
        pagamento.RealizarPagamento();
    }
    
    public void Status(IMetodoPagamento pagamento){
        pagamento.VerificarStatus();
    }
}