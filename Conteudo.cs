namespace Praticando_Polimorfismo;

internal class Conteudo
{

    public string Titulo { get; }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Detalhes de {Titulo}");
    }
}
