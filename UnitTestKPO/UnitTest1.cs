using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KPO;
using System.Collections.Generic;

namespace UnitTestKPO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumOfN()
        {
            KPO.Math ss = new KPO.Math();
            int test = ss.SumOfN(10);
            Assert.AreEqual(test, 55);
        }
        [TestMethod]
        public void TestSumNArray()
        {
            KPO.Math ss = new KPO.Math();
            int[] array = { 10, 10, 10, 10 };
            int test = ss.SumOfAvgArray(array);
            Assert.AreEqual(test, 10);
        }
        [TestMethod]
        public void TestDiskriminanta()
        {
            KPO.Math ss = new KPO.Math();

            // Linarna enčaba ko je a=0
            List<double> test = ss.QuadraticEquation(0,1.1,2);
            Assert.IsNull(test);

            List<double> lista = new List<double>();
            lista.Add(-0.43844718719116971);
            lista.Add(-4.5615528128088307);

            // Ko je diskriminanta pozitivna 
            List<double> test2 = ss.QuadraticEquation(2, 10, 4);
            CollectionAssert.AreEqual(lista, test2);

            lista = new List<double>();
            lista.Add(-1);
            lista.Add(-1);
            //Ko je diskriminanta 0  
            List<double> test3 = ss.QuadraticEquation(1, 2, 1);
            CollectionAssert.AreEqual(lista, test3);

            lista = new List<double>();
            lista.Add(-0.1);
            lista.Add(0.7);
            //Ko je diskriminanta negatvina... imaginarna
            List<double> test4 = ss.QuadraticEquation(10, 2, 5);
            CollectionAssert.AreEqual(lista, test4);
                       
        }
    }
}
