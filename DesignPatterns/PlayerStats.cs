using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class PlayerStats
    {
        // Thread safe singleton
        private static readonly PlayerStats instance = new PlayerStats();
        public static PlayerStats Instance
        {
            get
            {
                return instance;
            }
        }

        public float MaxVitality;
        public float CurrentVitality;
        public float MaxVigor;
        public float CurrentVigor;
        public float MaxMystic;
        public float CurrentMystic;
        public int PhysicalPower;
        public int MagicalPower;
        public int Agility;
        public int Charisma;
        public int Knowledge;
        public int Insight;
        public int Luck;
        public bool IsAlive;

        private PlayerStats()
        {
            // starting stats for player
            MaxVitality = 100f;
            CurrentVitality = MaxVitality;
            MaxVigor = 50f;
            CurrentVigor = MaxVigor;
            MaxMystic = 0f;
            CurrentMystic = MaxMystic;
            PhysicalPower = 1;
            MagicalPower = 0;
            Agility = 1;
            Charisma = 1;
            Knowledge = 1;
            Insight = 1;
            Luck = 1;
            IsAlive = true;
        }

        static PlayerStats()
        {

        }
    }
}
