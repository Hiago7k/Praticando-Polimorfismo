

namespace Praticando_Polimorfismo;

internal class Email : INotificacao
{

    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-mail " + mensagem);
    }
}
