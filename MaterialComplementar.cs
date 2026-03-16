namespace Praticando_Polimorfismo;

internal class MaterialComplementar : Conteudo
{

    public override void ExibirInfo()
    {
        Console.WriteLine($"Titulo {titulo}");
        Console.WriteLine($"Paginas: {Paginas}");

    }
}
