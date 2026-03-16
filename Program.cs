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
//List<Reserva> reservas = new List<Reserva>
//{
//    new ReservaPresencial("Trilha na serra"),
//    new ReservaOnline("Workshop de Culinaria Italiana")
//};

//foreach (var reserva in reservas)
//{
//    reserva.Confirmar();
//}

// Atividade 7
//List<Conteudo> conteudos = new List<Conteudo>
//{
//    new AulaGravada("Poo na pratica", 45),
//    new MaterialComplementar("Resumo do modulo 2", 12)
//};

//foreach (var conteudo in conteudos)
//{
//    conteudo.ExibirInfo();
//    Console.WriteLine();
//}

// Atividade 8

//List<Transporte> opcoes = new List<Transporte> 
//{
//    new Onibus(),
//    new Metro(),
//    new Bicileta()
//};

//int distancia = 10;

//foreach (var transporte in opcoes)
//{
//    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
//}

// Atividade 9

//List<IEmprestimo> perfisl = new List<IEmprestimo> 
//{
//    new EmprestimoEstudante(),
//    new EmprestimoEmpresario(),
//    new EmprestimoAposentado()
//};

//foreach (var perfil in perfisl) 
//{
//    decimal total = perfil.CalcularValorFinal(1000m, 12);
//    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
//}

// Atividade 10

