using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Weapon1
    {
        string name;
        int damage;
        public Weapon1( string name,int damage)
        {
            this.name = name;
            this.damage = damage;
        }

    }
    class Sword : Weapon1
    {
        public Sword(string name, int damage) : base(name, damage)
        {

        }
    }
}
