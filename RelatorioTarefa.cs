
namespace Praticando_Polimorfismo;

internal class RelatorioTarefa : TarefaAgendada
{

    public override void Executar()
    {
        Console.WriteLine("Gerando e enviado relatorio diario...");
    }
}
