

namespace Praticando_Polimorfismo;

internal class Imagem : Midia
{
    public Imagem(string resolucao, string nome)
      :base(nome)
    {
        Resolucao = resolucao;
    }

    public string Resolucao { get; set; }


    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - resolucao {Resolucao}");
    }
}
