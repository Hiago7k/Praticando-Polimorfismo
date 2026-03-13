namespace Praticando_Polimorfismo;

internal class ReservaPresencial : Reserva
{


    public override void Confirmar()
    {
        Console.WriteLine("Confirmando presencial");
        
    }
}
