
namespace Praticando_Polimorfismo;

internal class Video : Midia
{
    public Video(string nome, double duracao)
        :base(nome)
    {
        Duracao = duracao;
    }

    public double Duracao { get; set; }


    public override void ExibirDetalhes()
    {
        Console.WriteLine($"video: {Nome} - duracao: {Duracao} minutos");
    }
}
