public class ReservaUpgrade : IReserva
{
    public void ReservarVoo(string nomePassageiro, string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} com upgrade de classe realizada.");
    }

    public void CancelarReserva(string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} com upgrade de classe cancelada.");
    }

    public string VerificarStatusReserva(string numeroVoo)
    {
        return $"Reserva do voo {numeroVoo} com upgrade de classe confirmada.";
    }
}