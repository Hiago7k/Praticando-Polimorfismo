

namespace Praticando_Polimorfismo;

internal class Email : INotificacao
{

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-mail");
    }
}
