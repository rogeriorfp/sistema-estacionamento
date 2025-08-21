namespace SistemaEstacionamento.Models;

public class Veiculo
{
    public Placa Placa { get; init; }
    public Veiculo(Placa placa)
    {
        Placa = placa;
    }

}
