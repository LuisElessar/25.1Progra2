using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1_Semana1
{
    internal class Player : Character
    {
        protected int experience;
        protected int level;

        public int Experience { get { return experience; } }
        public int Level { get { return level; } }

        public Player (string name) : base(name)
        {
            experience = 0;
            level = 1;  
        }

        public void GainExp(int experience)
        {
            this.experience += experience;
            if (this.experience > 0)
        }
    }
}
