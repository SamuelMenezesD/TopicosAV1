public abstract  class ContaBancaria{

    public int idconta{get;set;}
    public double saldo {get;set;}

    public ContaBancaria(int idConta)
    {
        idconta = idConta;
        saldo = 0;
    }
    public virtual void Depositar(double valor)
    {
        saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

    public abstract void MostrarSaldo();

}
