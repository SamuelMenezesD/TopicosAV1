public interface IReserva
{
    void ReservarVoo(string nomePassageiro, string numeroVoo);
    void CancelarReserva(string numeroVoo);
    string VerificarStatusReserva(string numeroVoo);
}