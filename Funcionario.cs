namespace Praticando_Polimorfismo;

internal class Funcionario
{
    

    public virtual string GerarRelatorio()
    {
        // metodo a ser sobrescrito
        Console.WriteLine($"Relatorio do: ");
    }
}
