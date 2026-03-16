
namespace Praticando_Polimorfismo;

internal class Metro : Transporte
{

    public override int CalcularTempo(int distanciaKm)
    {
        int tempoEstimado = (distanciaKm + 5);
        return tempoEstimado;
        
    }
}
