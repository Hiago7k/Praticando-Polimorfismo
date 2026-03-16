namespace Praticando_Polimorfismo;

internal class AulaGravada : Conteudo
{
    
    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public int Duracao { get; }


    public override void ExibirInfo()
    {
        Console.WriteLine($"Titulo {Titulo}");
        Console.WriteLine($"Duracao: {Duracao} min");
    }
}
