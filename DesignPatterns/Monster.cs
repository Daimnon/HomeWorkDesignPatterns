using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Monster
    {
        #region Fields
        private float _vitality;
        private float _vigor;
        private float _mystic;
        private int _physicalPower;
        private int _magicalPower;
        private int _agility;
        private int _charisma;
        private int _knowledge;
        private int _insight;
        private int _luck;
        private bool _isAlive;
        #endregion

        #region Properties
        public float Vitality;
        public float Vigor;
        public float Mystic;
        public int PhysicalPower;
        public int MagicalPower;
        public int Agility;
        public int Charisma;
        public int Knowledge;
        public int Insight;
        public int Luck;
        public bool IsAlive;
        #endregion

        public Monster(int monsterLevel)
        {
            switch (monsterLevel)
            {
                case 1:
                    _vitality = 10;
                    _vigor = 2;
                    _mystic = 0;
                    _physicalPower = 1;
                    _magicalPower = 0;
                    _agility = 1;
                    _charisma = 0;
                    _knowledge = 0;
                    _insight = 0;
                    _luck = 1;
                    _isAlive = true;
                    break;

                case 2:
                    _vitality = 15;
                    _vigor = 3;
                    _mystic = 0;
                    _physicalPower = 2;
                    _magicalPower = 0;
                    _agility = 2;
                    _charisma = 0;
                    _knowledge = 0;
                    _insight = 0;
                    _luck = 1;
                    _isAlive = true;
                    break;

                case 3:
                    _vitality = 20;
                    _vigor = 4;
                    _mystic = 0;
                    _physicalPower = 2;
                    _magicalPower = 0;
                    _agility = 2;
                    _charisma = 0;
                    _knowledge = 0;
                    _insight = 0;
                    _luck = 2;
                    _isAlive = true;
                    break;

                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $"_vitality + {_vitality}" + Environment.NewLine
                 + $"_vigor + {_vigor}" + Environment.NewLine
                 + $"_mystic + {_mystic}" + Environment.NewLine
                 + $"_physicalPower + {_physicalPower}" + Environment.NewLine
                 + $"_magicalPower + {_magicalPower}" + Environment.NewLine
                 + $"_agility + {_agility}" + Environment.NewLine
                 + $"_charisma + {_charisma}" + Environment.NewLine
                 + $"_knowledge + {_knowledge}" + Environment.NewLine
                 + $"_insight + {_insight}" + Environment.NewLine
                 + $"_luck + {_luck}" + Environment.NewLine
                 + $"_isAlive + {_isAlive}" + Environment.NewLine;
        }
    }
}
