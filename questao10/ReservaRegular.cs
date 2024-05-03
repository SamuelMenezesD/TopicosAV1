public class ReservaRegular : IReserva
{
    public void ReservarVoo(string nomePassageiro, string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} realizada");
    }

    public void CancelarReserva(string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} cancelada.");
    }

    public string VerificarStatusReserva(string numeroVoo)
    {
        return $"Reserva do voo {numeroVoo} confirmada.";
    }
}