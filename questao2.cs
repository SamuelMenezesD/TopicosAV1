// O que são interfaces em orientação a objetos e qual é a sua importância naconstrução de sistemas em C#? 
//Dê um exemplo de como uma interface podeser utilizada para garantir a interoperabilidade entre diferentes classes em umsistema de pagamento online

// Interface em orientação a objetos define metodos e/ou propriedades para realizar ações em diferentes classes.

public interface IPagamento
{
    public string realizarpagamento(double valorpagamento);
}


public class ContaCorrente : IPagamento{

    public int idconta{get;set;}
    public double saldo {get;set;}

    public string realizarpagamento(double valorpagamento){
        if(saldo >= valorpagamento){
            return "Pagamento realizado";
        }
        else{
            return "Saldo insuficiente";
        }
    }


}





