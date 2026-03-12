
namespace Praticando_Polimorfismo;

internal class Push : INotificacao
{
    public void EnviarMensagem()
    {
        Console.WriteLine($"Enviando PUSH");
    }
}
