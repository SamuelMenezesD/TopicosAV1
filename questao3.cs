// Diferencie sobrecarga e sobreposição (ou sobrescrita) e forneça exemplos decada um em C#.

// A sobreposição é poder dar uma nova forma ao metodo, atraves do uso do conjunto modificador virtual (usado no metodo original que vai ser sobrescrito) e override 
// (que será usado na nova versão do metodo).
// A sobrecarga é poder ter vários metodos com mesmo nome, mas parametros de entrada diferentes.


// sobreposição

public class copo
{
	public virtual void Finalidade()
	{
		Console.WriteLine("copo normal");
	}
}

public class copotermico : copo
{
	public override void Finalidade()
	{
		Console.WriteLine("temperatura constante");
	}
}

// sobrecarga

public void Data(int dia) {

}

public void Data(int dia, int mes) {

}

public void Data(int dia, int mes, int ano) {
   
}
