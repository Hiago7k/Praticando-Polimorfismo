
namespace Praticando_Polimorfismo;

internal class Video : Midia
{
    public Video(double duracao, string nome)
        :base(nome)
    {
        Duracao = duracao;
    }

    public double Duracao { get; set; }
}
