using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class RegionalTeam : PsyopUnit
    {
        public void RegionalItems()
        {
            Mission();
            Language();
            PDD();
            Console.WriteLine();
        }

        public override void Mission()
        {
            Console.WriteLine("Tune in for influential news!");
        }

        public override void Language()
        {
            Console.WriteLine("Regionally depends on locale; Korean, Tagalog, French are the usual gotos!");
        }

        public override void PDD()
        {
            Console.WriteLine("Regional teams require more finesse usually; radio and televisiosn programs are a go!");
        }
    }
}
