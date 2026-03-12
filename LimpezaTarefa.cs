

namespace Praticando_Polimorfismo;

internal class LimpezaTarefa : TarefaAgendada
{

    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporarios do servidor...");
    }
}
