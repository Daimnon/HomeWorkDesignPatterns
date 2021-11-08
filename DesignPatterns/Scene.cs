using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Scene
    {
        private List<Monster> _monsters;

        public Scene()
        {
            _monsters = new List<Monster>(3);
            _monsters.Add(new Monster(1));
            _monsters.Add(new Monster(2));
            _monsters.Add(new Monster(3));
        }

        public void PlayerAttackMonsters()
        {
            foreach (Monster enemy in _monsters)
            {
                enemy.Vitality -= PlayerStats.Instance.PhysicalPower;
                enemy.Charisma -= PlayerStats.Instance.Charisma;
                enemy.Knowledge -= PlayerStats.Instance.Knowledge;
                enemy.Insight -= PlayerStats.Instance.Insight;
                enemy.Luck -= PlayerStats.Instance.Luck;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(enemy.ToString());

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (enemy.Charisma < PlayerStats.Instance.Charisma)
                    Console.WriteLine("You persuaded the enemy to flee ");
                else if (enemy.Knowledge < PlayerStats.Instance.Knowledge)
                    Console.WriteLine("You have trapped the enemy");
                else if (enemy.Insight < PlayerStats.Instance.Insight)
                    Console.WriteLine("You predict the enemy moves and apperhand him");
                Console.WriteLine();

                Console.ResetColor();
            }
        }
    }
}
