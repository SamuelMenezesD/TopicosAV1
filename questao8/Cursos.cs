public abstract class Cursos
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; }

    public Cursos(string nome)
    {
        Nome = nome;
        Notas = new List<double>();
    }

    public virtual void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }

    public abstract double CalcularMedia();

    public abstract void GerarCertificado();
}
