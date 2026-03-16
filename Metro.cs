
namespace Praticando_Polimorfismo;

internal class Metro : Transporte
{

    public override void CalcularTempo(int distanciaKm)
    {
        var tempoEstimado = (distanciaKm + 5) ;

    }
}
