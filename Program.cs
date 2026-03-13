using Praticando_Polimorfismo;

// Ativ 1
//Calculadora calc = new Calculadora();
//calc.Somar(10, 20);
//calc.Somar(5, 10, 15);
//calc.Somar(3.5, 2.8);

// Atividade 2
//SobreScrita
//Funcionario f1 = new Gerente();
//Funcionario f2 = new Desenvolvedor();
//Funcionario f3 = new Analista();

//Console.WriteLine(f1.GerarRelatorio());
//Console.WriteLine(f2.GerarRelatorio());
//Console.WriteLine();
//Console.WriteLine(f3.GerarRelatorio());

// Atividade 3

//List<INotificacao> notificacaos = new List<INotificacao>
//{
//    new Email(),
//     new Sms(),
//    new Push()
//};

//foreach (var notificacao in notificacaos)
//{
//    notificacao.EnviarMensagem("Sistema fora do ar!");
//}

// Atividade 4
// Diferentes tarefas armazenadas numa lista DINAMICA

//List<TarefaAgendada> tarefas = new List<TarefaAgendada>
//{
//    new BackupTarefa(),
//    new RelatorioTarefa(),
//    new LimpezaTarefa()
//};

//foreach (var tarefa in tarefas)
//{
//    tarefa.Executar();
//}

// Atividade 5
//List<Midia> midias = new List<Midia>
//{
//    new  Imagem("paisagem.jpg", "1920x1080"),
//    new Video("filme.mp4", 120)
//};


//foreach (var midia in midias)
//{
//    midia.ExibirDetalhes();
//}

// Atividade 6
List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha na serra"),
}; 