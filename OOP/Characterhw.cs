using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Characterhw
    {
        public string nickname { set; get; }
        public string attack { get; set; }
        public int health { get; set; }

        internal void Attack(Characterhw player2)
        {
            Console.WriteLine("your attac size : ");
        }

        private void Attack()
        {
            Console.WriteLine($" player attack {attack}");
        }


    }
}
