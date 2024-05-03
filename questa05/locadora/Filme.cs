public class Filme{
     private string Titulo{get; set;}
    private string Genero{get;set;}
    private double Duracao {get;set;}
    private bool Disponivel {get;set;}

    public string Locacao(string nome){

        if (Disponivel == true){
            Disponivel = false;
            return nome +  "locação registrada ";
        }
        else{
            return "filme já locado";
        }
    }
    public string Devolucao(string nome){

        Disponivel = true;
        return "Devolução realizada ";
    }
    public string Verificardisponibilidade(string nome){

        if (Disponivel == true)
        {
            return "Filme disponivel";
        }
        else{
            return "filme não esta disponivel";
        }
    }

}