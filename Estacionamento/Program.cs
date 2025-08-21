using SistemaEstacionamento.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine(
    """
    Seja bem vindo ao sistema de estacionamento!
    Digite o preço inicial:
    """);

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new(precoInicial, precoPorHora);

while (true)
{
    Console.Clear();
    Console.WriteLine(
        """
        Digite a sua opção:
        1 - Cadastrar Veículo
        2 - Remover Veículo
        3 - Listar Veículos
        4 - Sair
        """
    );

    ConsoleKeyInfo opcao = Console.ReadKey(true);

    Action acao = opcao.Key switch
    {
        ConsoleKey.D1 or ConsoleKey.NumPad1 => () => estacionamento.AdicionarVeiculo(),
        ConsoleKey.D2 or ConsoleKey.NumPad2 => () => estacionamento.RemoverVeiculo(),
        ConsoleKey.D3 or ConsoleKey.NumPad3 => () => estacionamento.ListarVeiculos(),
        ConsoleKey.D4 or ConsoleKey.NumPad4 => () => Environment.Exit(0),
        _ => () => Console.WriteLine("Opção inválida, tente novamente.")
    };
    acao();

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey();
}
