namespace Praticando_Polimorfismo;

internal class ReservaPresencial : Reserva
{
    public ReservaPresencial(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }


    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva presencial: {Nome}");
        Console.WriteLine($"Ponto de encontro: Praca Central as 8h");
    }
}
