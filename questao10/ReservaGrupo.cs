public class ReservaGrupo : IReserva
{
    public void ReservarVoo(string nomePassageiro, string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} para o grupo grande realizada");
    }

    public void CancelarReserva(string numeroVoo)
    {
        Console.WriteLine($"Reserva do voo {numeroVoo} para o grupo grande cancelada.");
    }

    public string VerificarStatusReserva(string numeroVoo)
    {
        return $"Reserva do voo {numeroVoo} para o grupo grande confirmada.";
    }
}