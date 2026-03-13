
namespace Praticando_Polimorfismo;

internal class Midia
{
    public Midia(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }


    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome}");
    }
}
