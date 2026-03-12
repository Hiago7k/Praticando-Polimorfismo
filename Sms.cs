

namespace Praticando_Polimorfismo;

internal class Sms : INotificacao
{
    public  void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS " + mensagem);
    }
}
