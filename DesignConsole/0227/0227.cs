using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignConsole._0227
{
    public class Cat
    {
        private string name;
        public Cat(string name) {
            this.name = name;
        }

        public delegate void CatShoutEventHandler();

        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine($"我是{name}");
            if (CatShout != null)
            {
                CatShout();
            }
                
        }
    }

    public class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine($"猫来了，{name}快跑");
        }
    }
}
