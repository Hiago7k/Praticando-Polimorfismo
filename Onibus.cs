namespace Praticando_Polimorfismo;

internal class Onibus : Transporte
{

    public override int CalcularTempo(int distanciaKm)
    {
        int tempoEstimado = (distanciaKm * 2) + 5;
        return tempoEstimado;
    }
}
