
namespace Praticando_Polimorfismo;

internal class Push : INotificacao
{
    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando PUSH");
    }
}
