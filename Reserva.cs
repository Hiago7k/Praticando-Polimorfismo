namespace Praticando_Polimorfismo;

internal class Reserva
{
    public Reserva(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;; }
    public virtual void Confirmar()
    {
        Console.WriteLine($"Confirmando...");
    }
}
