using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class PsyopUnit
    {

        public void PsyopItems()
        {
            Mission();
            Language();
            PDD();
            Console.WriteLine();
        }

        public virtual void Mission()
        {
            Console.WriteLine("Win those hearts and minds!");
        }

        public virtual void Language()
        {
            Console.WriteLine("All Psyopers learn a language.");
        }

        public virtual void PDD()
        {
            Console.WriteLine("I am the Print Developement Detachment!");
        }
    }
}
