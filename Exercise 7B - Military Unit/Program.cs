using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

        static void doWork()
        {
            PsyopUnit PU = new PsyopUnit();
            PU.PsyopItems();

            TacticalTeam TT = new TacticalTeam();
            TT.TacticalItems();

            RegionalTeam RT = new RegionalTeam();
            RT.RegionalItems();

            Console.ReadKey();
        }
    }
}
