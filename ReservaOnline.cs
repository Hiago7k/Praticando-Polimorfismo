
namespace Praticando_Polimorfismo;

internal class ReservaOnline : Reserva
{
    public ReservaOnline(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }

    public override void Confirmar()
    {
        Console.WriteLine("Reserva online");
    }
}
