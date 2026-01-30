namespace SpaceManager.Models;

public class NaveCargueiro(string modelo, string identificador, double carga) : Veiculo(modelo, identificador)
{
    //O T no final da propriedade e de toneladas
    protected double _cargaAtual = carga;
    protected double _pesoDoCargueiroT = 15;



    public override string Mover(double distancia)
    {
        string statusCarga;
        switch (_cargaAtual)
        {
            case <= 0:
                ConsumoMedio = 50;
                statusCarga = "Caminhão vazio";
                break;
            case > 0 and <= 20:
                ConsumoMedio = 30;
                statusCarga = "Carga leve/média";
                break;
            case > 20 and <= 40:
                ConsumoMedio = 15;
                statusCarga = "Carga pesada";
                break;
            default:
                ConsumoMedio = 5;
                statusCarga = "Excesso de peso!";
                break;
        }

        double combustivelGasto = distancia / ConsumoMedio;

        if (_combustivel >= combustivelGasto)
        {
            _combustivel -= combustivelGasto;
            return $"{Identificador} (Cargueiro) moveu {distancia}Km com carga de {_cargaAtual}T,{statusCarga} Combustivel restante: {_combustivel:F2}";
        }
        else
        {
            return $"{Identificador} sem combustivel para mover {distancia}Km!";
        }

    }
}