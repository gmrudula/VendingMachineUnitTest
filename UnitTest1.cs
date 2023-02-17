using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachineProject;

namespace VendingMachineUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCoin1()
        {
            VendingMachineProject.Program.ValidateEnteredMoney(0.25);
        }
        [TestMethod]
        public void TestCoin2()
        {
            VendingMachineProject.Program.ValidateEnteredMoney(8);
        }
    }
}
