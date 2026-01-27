using System.Collections.Generic;
namespace SpaceManager.Models;

using SpaceManager.Interfaces;
public class NaveCaca : Veiculo, ICombativel
{
    public  NaveCaca(string modelo, string identificador) : base(modelo, identificador)
    {
        _combustivel = 100;
    }

    public override void Mover(double distancia)
    {
        double consumo = distancia * 5;
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

    public bool Atirar()
    {
        if (_combustivel >= 10)
        {
            _combustivel -= 10;
            Console.WriteLine($"{Identificador} disparou lasers! (-10 combustível)");
            return true;
        }

        Console.WriteLine($"{Identificador} falhou ao atirar: Energia insuficiente.");
        return false;
    }
}