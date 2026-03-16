

namespace Praticando_Polimorfismo;

internal class Bicileta : Transporte
{

    public override int CalcularTempo(int distanciaKm)
    {
        int tempoEstimado = (distanciaKm * 4);
        return tempoEstimado;
    }
}
