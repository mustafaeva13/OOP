using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Game
    {
        public string Character { get; set; }
        public string Enemy { get; set; }   
        public string Item { get; set; }

        public void position()
        {
            Console.WriteLine("enter your position:");
        }
        public void rotation()
        {
            Console.WriteLine("your rotation:");
        }
        public void scale()
        {
            Console.WriteLine("your scale:");
        }
    }
}
