using SpaceManager.Models;
using SpaceManager.Interfaces;

// Note que não importamos Records nem NaveCargueiro ainda para não dar erro
Console.WriteLine("--- INICIANDO TESTE DA NAVE CAÇA ---");

// 1. Instanciando a NaveCaca
// Certifique-se de que o construtor na classe NaveCaca aceita (modelo, identificador)
NaveCaca xWing = new NaveCaca("X-Wing", "Red-Five");

// 2. Testando o Abastecimento (Método Virtual da base Veiculo)
xWing.Abastecer(10);

// 3. Testando a Movimentação (Método Override na NaveCaca)
// Lembre-se: Caça gasta 5 por km. 20km = 100 de combustível.
xWing.Mover(100); 

// 4. Testando o Combate (Interface ICombativel)
// Usamos o operador 'is' para verificar se a nave sabe lutar
if (xWing is ICombativel atacante)
{
    Console.WriteLine("Sistemas de armas detectados!");
    atacante.Atirar(0.1);
}

Console.WriteLine($"Status Final: {xWing.Identificador} - Combustível: {xWing.SaldoCombustivel}"); // Se você criou uma propriedade para ver o saldo

Console.WriteLine("--- INICIANDO TESTE DA NAVE CARGUEIRA ---");

NaveCargueiro cFox = new NaveCargueiro("c-fox", "Fox-C",10);

cFox.Abastecer(25);

cFox.Mover(100);