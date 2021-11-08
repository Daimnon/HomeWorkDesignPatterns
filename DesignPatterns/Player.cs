using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Player
    {
        private readonly string _name;
        private readonly float _vitality;
        private readonly float _vigor;
        private readonly float _mystic;
        private readonly int _physicalPower;
        private readonly int _magicalPower;
        private readonly int _agility;
        private readonly int _charisma;
        private readonly int _knowledge;
        private readonly int _insight;
        private readonly int _luck; 

        public Player()
        {
            _name = "Jhon Doe";
            _vitality = PlayerStats.Instance.CurrentVitality;
            _vigor = PlayerStats.Instance.CurrentVigor;
            _mystic = PlayerStats.Instance.CurrentMystic;
            _physicalPower = PlayerStats.Instance.PhysicalPower;
            _magicalPower = PlayerStats.Instance.MagicalPower;
            _agility = PlayerStats.Instance.Agility;
            _charisma = PlayerStats.Instance.Charisma;
            _knowledge = PlayerStats.Instance.Knowledge;
            _insight = PlayerStats.Instance.Insight;
            _luck = PlayerStats.Instance.Luck;
        }

        public override string ToString()
        {
            return $"_name + {_name}" + Environment.NewLine
                 + $"_vitality + {_vitality}" + Environment.NewLine
                 + $"_vigor + {_vigor}" + Environment.NewLine
                 + $"_mystic + {_mystic}" + Environment.NewLine
                 + $"_physicalPower + {_physicalPower}" + Environment.NewLine
                 + $"_magicalPower + {_magicalPower}" + Environment.NewLine
                 + $"_agility + {_agility}" + Environment.NewLine
                 + $"_charisma + {_charisma}" + Environment.NewLine
                 + $"_knowledge + {_knowledge}" + Environment.NewLine
                 + $"_insight + {_insight}" + Environment.NewLine
                 + $"_luck + {_luck}" + Environment.NewLine;
        }
    }
}
