namespace Praticando_Polimorfismo;

internal class Onibus : Transporte
{

    public override void CalcularTempo(int distanciaKm)
    {
        var tempoEstimado = (distanciaKm * 2) + 5;
    }
}
