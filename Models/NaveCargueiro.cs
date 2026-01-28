namespace SpaceManager.Models;

public class NaveCargueiro(string modelo, string identificador, double carga) : Veiculo(modelo, identificador)
{
    //O T no final da propriedade e de toneladas
    protected double _capacidadeDePesoT = 40;
    protected double _cargaAtual = carga;
    protected double _pesoDoCargueiroT = 15;

    public override void Mover(double distancia)
    {
        switch (_cargaAtual)
        {
            case <= 0:
                _consumoMedio = 50;
                Console.WriteLine("Caminhão vazio");
                break;
            case > 0 and <= 20:
                _consumoMedio = 30;
                Console.WriteLine("Carga leve/média");
                break;
            case > 20 and <= 40:
                _consumoMedio = 15;
                Console.WriteLine("Carga pesada");
                break;
            default:
                _consumoMedio = 5;
                Console.WriteLine("Excesso de peso!");
                break;
        }

        double combustivelGasto = distancia / _consumoMedio;

        if (_combustivel >= combustivelGasto)
        {
            _combustivel -= combustivelGasto;
            Console.WriteLine($"{Identificador} (Cargueiro) moveu {distancia}Km. Combustivel restante: {_combustivel:F2}");
        }
        else
        {
            Console.WriteLine($"{Identificador} sem combustivel para mover {distancia}Km!");
        }

    }
}