

namespace Praticando_Polimorfismo;

internal class Sms : INotificacao
{
    public void EnviarMensagem()
    {
        Console.WriteLine($"Enviando SMS");
    }
}
