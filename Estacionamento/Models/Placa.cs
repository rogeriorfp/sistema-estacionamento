namespace SistemaEstacionamento.Models;

public record Placa
{
    public string Numero { get; init; }
    public Placa(string numero)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(numero.Length, 7, nameof(numero));

        Numero = numero!.ToUpperInvariant();
    }

    public override string ToString() => Numero;
}
