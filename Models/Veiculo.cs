
namespace SpaceManager.Models;

public abstract class Veiculo
{
    protected double _combustivel;
    protected string _modelo;
    public string Modelo
    {
        get => _modelo;
    }
    protected double _consumoMedio;
    public double ConsumoMedio { get; set; }
    private string _identificador = string.Empty;
    public string Identificador
    {
        get => _identificador;
        set => _identificador = value.ToUpper();
    }

    protected double _saldoCombustivel;
    public double SaldoCombustivel
    {
        get => _combustivel;
    }

    public Veiculo(string modelo, string identificador)
    {
        _modelo = modelo;
        Identificador = identificador;
    }

    //public abstract void Consumo(double distanci, double consumoMedio, double _combustivel);

    public abstract string Mover(double distancia);
    public virtual string Abastecer(double quantidade)
    {
        if (quantidade > 0)
        {
            _combustivel += quantidade;
            return $"{Identificador} abastecido com {quantidade} unidades.";
        }
        return $"ALERTA: Quantidade de abastecimento inválida para a nave {Identificador}.";

    }
}