

namespace Praticando_Polimorfismo;

internal class Sms : INotificacao
{
    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS");
    }
}
