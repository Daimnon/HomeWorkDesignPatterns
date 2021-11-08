using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            Player player = new Player();

            Console.ForegroundColor = ConsoleColor.Green;
            player.ToString();
            Console.WriteLine();
            Console.ResetColor();


            scene.PlayerAttackMonsters();
        }
    }
}
