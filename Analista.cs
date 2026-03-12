

namespace Praticando_Polimorfismo;

internal class Analista : Funcionario
{

    public override string GerarRelatorio()
    {
        return $"Exibindo relatorio do analista: funcao analtica resolver problemas";
    }
}
