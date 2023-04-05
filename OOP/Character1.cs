using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Class
    {
        public string name { get; set; }
        public string nickname { get; set; }
        public int age { get; set; }

        public  void Player()
        {
            Console.WriteLine("Player nickname:");
        }
        public void Enemy()
        {
            Console.WriteLine("your enemy health:");
        }
    }
}
