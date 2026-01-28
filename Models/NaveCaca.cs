namespace SpaceManager.Models;

using SpaceManager.Interfaces;
public class NaveCaca : Veiculo, ICombativel
{
    public  NaveCaca(string modelo, string identificador) : base(modelo, identificador)
    {
        _combustivel = 10;  
    }


    public override void Mover(double distancia)
    {
        double consumoMedio = 20;
        double consumo = distancia / consumoMedio;
        if (_combustivel >= consumo)
        {
            _combustivel -= consumo;
            Console.WriteLine($"{Identificador} (Caça) moveu {distancia}Km. Combustivel restante: {_combustivel}");
        }
        else
        {
            Console.WriteLine($"{Identificador} sem combustivel para mover {distancia}Km!");
        }
    }

    public bool Atirar(double carga)
    {
        if (_combustivel >= carga)
        {
            _combustivel -= carga;
            Console.WriteLine($"{Identificador} disparou lasers! ( {carga} combustível (E utilizado o combustível para gerar enegia de desparo))");
            return true;
        }

        Console.WriteLine($"{Identificador} falhou ao atirar: Energia insuficiente.");
        return false;
    }
}