namespace Praticando_Polimorfismo;

internal class Gerente : Funcionario
{

    public  override string GerarRelatorio()
    {
        return $"relatorio do Gerente";
    }
}
