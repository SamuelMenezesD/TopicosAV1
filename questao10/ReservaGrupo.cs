public class ReservaGrupo : IReserva{
    public string NomeDoGrupo {get;set;}
    public string Voo {get;set;}
    public int NumPessoas {get;set;}
    public string Status {get;set;}
    public ReservaGrupo(string nomeDoGrupo, string voo, int numPessoas)
    {
        NomeDoGrupo = nomeDoGrupo;
        Voo = voo;
        NumPessoas = numPessoas;
        Status = "Reserva pendente";
    }

    public void ReservarVoo()
    {
        Status = "Reservado";
        Console.WriteLine(NomeDoGrupo + "  a reserva em grupo para o voo: " + Voo + " foi realizada.");
    }

    public void CancelarReserva()
    {
        Status = "Cancelado";
        Console.WriteLine(NomeDoGrupo + " a reserva em grupo para o voo: " + Voo + " foi cancelada.");
        Voo = "";
    }

    public void VerificarStatusReserva()
    {
        Console.WriteLine("status da reserva: " + Status);
    }
}