namespace Praticando_Polimorfismo;

internal class Gerente : Funcionario
{

    public override void GerarRelatorio(string relatorio)
    {
        Console.WriteLine($"Relatorio do gerente: supervisiona a equipe");
    }
}
