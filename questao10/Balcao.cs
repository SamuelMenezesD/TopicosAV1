public class Balcao{
    public string ReservarVoo(IReserva reserva)
    {
        reserva.ReservarVoo();
        return "Reservado";
    }

    public string CancelarReserva(IReserva reserva)
    {
        reserva.CancelarReserva();
        return "cancelado";
    }

    public string VerificarStatusReserva(IReserva reserva)
    {
        reserva.VerificarStatusReserva();
        return "Informações do voo";
    }

}