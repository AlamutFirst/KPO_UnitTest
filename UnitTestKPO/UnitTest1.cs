using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KPO;
namespace UnitTestKPO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            KPO.Math ss = new KPO.Math();
            int test = ss.SumOfN(10);
            Assert.AreEqual(test, 55);
        }
    }
}
