using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSem1
{
    internal class Player : Character
    {
        protected int experience;
        protected int level;

        public int Experience { get { return experience; } }
        public int Level { get { return level; } }

        public Player(string name) : base(name) 
        {
            experience = 0;
            level = 1;
        }

        public void GainExperience(int xp)
        {
            experience += xp;
            if (experience >= level * 100)
            {
                level++;
                experience = 0;
                Console.WriteLine($"¡Subiste al nivel {level}!");
            }
        }

        public override void ShowStatus()
        {
            Console.WriteLine($"Jugador: {Name}, Nivel: {Level}, Experiencia: {Experience}");
        }
    }
}
