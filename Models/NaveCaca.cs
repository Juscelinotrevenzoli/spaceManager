namespace SpaceManager.Models;

using SpaceManager.Interfaces;
public class NaveCaca : Veiculo, ICombativel
{
    public  NaveCaca(string modelo, string identificador) : base(modelo, identificador)
    {
        _combustivel = 10;  
    }


    public override string Mover(double distancia)
    {
        double consumoMedio = 20;
        double consumo = distancia / consumoMedio;
        if (_combustivel >= consumo)
        {
            _combustivel -= consumo;
           return $"{Identificador} (Caça) moveu {distancia}Km. Combustivel restante: {_combustivel}";
        }
        else
        {
            return $"{Identificador} sem combustivel para mover {distancia}Km!";
        }
    }

    public string Atirar(double carga)
    {
        if (_combustivel >= carga)
        {
            _combustivel -= carga;
            
            return $"{Identificador} disparou lasers! ( {carga} combustível (E utilizado o combustível para gerar enegia de desparo))";
        }
        
        return $"{Identificador} falhou ao atirar: Energia insuficiente.";
    }
}