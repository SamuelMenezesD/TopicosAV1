public class CursoIngles : Cursos
{
    public CursoIngles(string nome) : base(nome)
    {
    }

    public override double CalcularMedia()
    {
        double soma = 0;
        foreach (var nota in Notas)
        {
            soma += nota;
        }
        return soma / Notas.Count;
    }

    public override void GerarCertificado()
    {
        Console.WriteLine($"Certificado de conclusão do curso de Inglês - {Nome}");
    }
}