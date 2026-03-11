
namespace Praticando_Polimorfismo;

internal class Calculadora
{

    public void Somar(int numero1, int numero2)
    {
        var resposta = numero1 + numero2;
        Console.WriteLine(resposta);
    }


    public void Somar(int numero1, int numero2, int numero3)
    {
        var resposta = numero1 + numero2 + numero3;
        Console.WriteLine(resposta);
    }

    public void Somar(double numero1, double numero2)
    {
        var resposta = numero1 + numero2;
        Console.WriteLine(resposta);
    }


}
