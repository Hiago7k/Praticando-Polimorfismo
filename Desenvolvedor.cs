namespace Praticando_Polimorfismo;

internal class Desenvolvedor : Funcionario
{


    public override void GerarRelatorio(string relatorio)
    {
        Console.WriteLine($"Relatorio do desenvolvedor: programa e resolve bugs");
    }
}
