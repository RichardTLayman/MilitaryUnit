using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class TacticalTeam : PsyopUnit
    {
        public void TacticalItems()
        {
            Mission();
            Language();
            PDD();
            Console.WriteLine();
        }

        public override void Mission()
        {
            Console.WriteLine("Leaflet drops for the win!");
        }

        public override void Language()
        {
            Console.WriteLine("We tend to speak Arabic, Poshtu, and other arabian languages!");
        }

        public override void PDD()
        {
            Console.WriteLine("Tactically, we make leaflets!");
        }
    }
}
