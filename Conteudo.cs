namespace Praticando_Polimorfismo;

internal class Conteudo
{
    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }

    public string Titulo { get; }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Detalhes de {Titulo}");
    }
}
