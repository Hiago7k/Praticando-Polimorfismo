
namespace Praticando_Polimorfismo;

internal class ReservaOnline : Reserva
{


    public override void Confirmar()
    {
        Console.WriteLine("Reserva online");
    }
}
