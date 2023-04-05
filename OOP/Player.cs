using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Player
    {
        public string Health { get; set; }
        public string movementSpeed { get; set; }
        public string damage { get; set; }


        public void Attack()
        {
            Console.WriteLine("Player attack this :");
        }
        public void TakeDamage()
        {
            Console.WriteLine("");
        }
       
    }
}
