using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1_Semana1
{
    internal abstract class Character
    {
        protected string name;

        public string Name { get { return name; } } 

        public Character(string name)
        {
            this.name = name;
        }
    }
}
