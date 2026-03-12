namespace Praticando_Polimorfismo;

internal class Desenvolvedor : Funcionario
{


    public override string GerarRelatorio()
    {
        return $"Relatorio do desenvovledor";
    }
}
