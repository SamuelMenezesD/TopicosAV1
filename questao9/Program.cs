IMetodoPagamento metodoPagamento = new CartaoCredito();
bool pagamentoAprovado = metodoPagamento.RealizarPagamento(67.79);
string statusPagamento = metodoPagamento.VerificarStatus();