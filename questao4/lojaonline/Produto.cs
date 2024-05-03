public class Produto{

    private string Nome{get; set;}
    private double Preco{get;set;}
    private int Quantidadeestoque {get;set;}

     public Produto(string nome, double preco, int quantidadeestoque)
    {
        Nome = nome;
        Preco = preco;
        Quantidadeestoque = quantidadeestoque;
    }
    public int addunidadeestoque(int quantidadeadicionada){

        return Quantidadeestoque += quantidadeadicionada;
    }

    public int retirarunidadeestoque(int quantidaderetirar){

        if (Quantidadeestoque >= quantidaderetirar){
            return Quantidadeestoque -= quantidaderetirar;
        }
        else{
            return Quantidadeestoque ;
        }
        
    }
    public double calcularvalortotalestoque (){

        double valor;

        valor = Quantidadeestoque * Preco;

        return valor;
    }


}