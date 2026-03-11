using Praticando_Polimorfismo;

// Ativ 1
//Calculadora calc = new Calculadora();
//calc.Somar(10, 20);
//calc.Somar(5, 10, 15);
//calc.Somar(3.5, 2.8);

// Atividade 2
Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());
