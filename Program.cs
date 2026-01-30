using SpaceManager.Models;
using SpaceManager.Interfaces;
using SpaceManager.Records;

// Note que não importamos Records nem NaveCargueiro ainda para não dar erro
// Console.WriteLine("--- INICIANDO TESTE DA NAVE CAÇA ---");
// NaveCaca xWing = new("X-Wing", "Red-Five");
// SpaceLogger.ImprimirStatus([
//     xWing.Abastecer(100),
//     xWing.Mover(100)
// ]);
// Console.WriteLine("--- INICIANDO TESTE DA NAVE CARGUEIRA ---");
// Console.WriteLine("--- RESUMO DE VIAGEM DTO COM RECORDS ---");


// 1. Criando a Frota (Note como aceitamos tipos diferentes na mesma lista)
List<Veiculo> frota = new List<Veiculo>
{
    new NaveCaca("X-Wing", "Red-Five"),
    new NaveCargueiro("Millennium Falcon", "Falcon-01", 30), // Carga pesada
    new NaveCaca("TIE Fighter", "Black-One"),
    new NaveExploradora("Voyager", "EXP-01") // Se você já criou a nova classe!
};

Console.WriteLine("======= SPACE MANAGER 2026 - CONTROLE DE FROTA =======");

// 2. Abastecendo todas as naves
Console.WriteLine("\n⛽ ABASTECENDO FROTA:");
foreach (var nave in frota)
{
    // Capturamos a string que o método retorna
    string logAbastecimento = nave.Abastecer(100); 
    Console.WriteLine(logAbastecimento);
}

// 3. Movimentando a frota (O Princípio Aberto/Fechado em ação)
Console.WriteLine("\n🚀 ORDEM DE MOVIMENTAÇÃO (100km):");
foreach (var nave in frota)
{
    // O Program não sabe se é caça ou carga, ele só pede para "Mover"
    string relatorioViagem = nave.Mover(100);
    Console.WriteLine(relatorioViagem);
}

// 4. Testando Combate apenas em quem é ICombativel
Console.WriteLine("\n🔫 STATUS DE COMBATE:");
foreach (var nave in frota)
{
    if (nave is ICombativel atacante)
    {
        // Aqui você pode precisar ajustar o Atirar para retornar string também se quiser ser 100% SOLID!
        string relatorioDeCombate = atacante.Atirar(1.0);
        Console.WriteLine(relatorioDeCombate);
        
    }
}

Console.WriteLine("\n=====================================================");