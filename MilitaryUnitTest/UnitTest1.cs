using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MilitaryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mission();
            PsyopUnit.Mission();
            MilitaryUnit.PsyopUnit.Mission();

            PsyopUnit PU = new PsyopUnit();
            PU.Mission();
        }
    }
}
