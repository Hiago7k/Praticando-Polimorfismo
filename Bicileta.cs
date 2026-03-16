

namespace Praticando_Polimorfismo;

internal class Bicileta : Transporte
{

    public override void CalcularTempo(int distanciaKm)
    {
        var tempoEstimado = (distanciaKm * 4);

    }
}
