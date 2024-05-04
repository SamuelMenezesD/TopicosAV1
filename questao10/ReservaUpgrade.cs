public class ReservaUpgrade : IReserva{
     public string Nome {get;set;}
    public string Voo {get;set;}
    public string Status {get;set;}

    public ReservaUpgrade(string nome, string voo){
        Nome = nome;
        Voo = voo;
        Status = "Reserva pendente";
    }

    public void ReservarVoo(){
        Status = "Reservado";
        Console.WriteLine(Nome + " a reserva upgrade para o voo: " + Voo + " foi realizada.");
    }

    public void CancelarReserva(){
        Status = "Cancelado";
        Console.WriteLine(Nome + " a reserva upgrade para o voo: " + Voo + " foi cancelada.");
        Voo = "";
    }

    public void VerificarStatusReserva(){
        Console.WriteLine("status da reserva: " + Status);
    }
}