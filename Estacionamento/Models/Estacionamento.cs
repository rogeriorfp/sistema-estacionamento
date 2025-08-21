namespace SistemaEstacionamento.Models;

public class Estacionamento
{

    private readonly List<Veiculo> veiculos;
    private readonly decimal _precoInicial;
    private readonly decimal _precoPorHora;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        veiculos = [];
        _precoInicial = precoInicial;
        _precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        Placa placa = ObterPlaca();
        Veiculo veiculo = new(placa);
        veiculos.Add(veiculo);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        Placa placa = ObterPlaca();

        if (!veiculos.Any(v => v.Placa == placa))
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            return;
        }


        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas = Convert.ToInt32(Console.ReadLine());
        decimal valorTotal = _precoInicial + _precoPorHora * horas;

        veiculos.RemoveAll(v => v.Placa == placa);

        Console.WriteLine($"O veículo {placa.Numero} foi removido e o preço total foi de: R$ {valorTotal}");

    }
    public void ListarVeiculos()
    {
        if (!veiculos.Any())
        {
            Console.WriteLine("Não há veículos estacionados.");
            return;
        }

        Console.WriteLine("Os veículos estacionados são:");
        foreach (Veiculo veiculo in veiculos)
        {
            Console.WriteLine(veiculo.Placa);
        }
    }

    private Placa ObterPlaca()
    {
        string? placaDigitada = Console.ReadLine();
        return new Placa(placaDigitada!);
    }
}
