namespace Praticando_Polimorfismo;

internal class MaterialComplementar : Conteudo
{
    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        Paginas = paginas;
    }

    public int Paginas { get; }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Titulo {Titulo}");
        Console.WriteLine($"Paginas: {Paginas}");
    }
}
