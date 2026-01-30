namespace SpaceManager.Models;

public static class SpaceLogger
{
    public static void ImprimirStatus(List<string> mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (var resposta in mensagem)
        {
            Console.WriteLine($"[LOG DE BORDO]: {resposta}");
        }
        Console.ResetColor();
    }
}