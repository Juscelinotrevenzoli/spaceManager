namespace SpaceManager.Models;

public class NaveExploradora(string identificador, string modelo) : Veiculo(identificador, modelo)
{
    public override string Mover(double distancia)
    {
        double consumoMedio = 200;
        double consumo = distancia / consumoMedio;
        if (_combustivel >= consumo)
        {
            _combustivel -= consumo;
           return $"{Identificador} (Exploradora) moveu {distancia}Km. Combustivel restante: {_combustivel}";
        }
        else
        {
            return $"{Identificador} sem combustivel para mover {distancia}Km!";
        }
    }
}