using System;
using System.Collections.Generic;
using KPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKPO
{
    [TestClass]
    public class UnitTest2
    {
        //Dobi vse elemente
        [TestMethod]
        public void DBGetAllData()
        {
            var testData = new FakeTablecs();

            testData.lista = new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 } };

            var users = new Users(testData);

            var reslut = users.GetAll();

            int i = 0;
            foreach (var item in reslut)
            {
                i++;

            }
            Assert.AreEqual(4, i);
        }
        //Dobi en element sortirano po spremenljivki ime naraščejoče
        [TestMethod]
        public void DBGetFirstItem()
        {

            var testData = new FakeTablecs();

            testData.lista = new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 } };

            var user = new Users(testData);

            var reslut = user.GetFirstItem();
            Assert.AreEqual("Bob", reslut.ime);
            Assert.AreEqual("Smith", reslut.priimek);
            Assert.AreEqual("Doma", reslut.naslov);
        }
        [TestMethod]
        public void DBGetUserByName()
        {

            var testData = new FakeTablecs();

            testData.lista = new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 } };

            var user = new Users(testData);

            var reslut = user.GetUserByName("Bob");
            var reslut2 = user.GetUserByName("ggggg");
            Assert.AreEqual("Bob", reslut.ime);
            Assert.IsNull(reslut2);
        }
        [TestMethod]
        public void DBGetUserByAddress()
        {

            var testData = new FakeTablecs();

            testData.lista = new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 } };

            var user = new Users(testData);

            var reslut = user.GetUserByAddres("Služba");
            var reslut2 = user.GetUserByAddres("rrrrrrr");
            Assert.AreEqual("Služba", reslut.naslov);
            Assert.IsNull(reslut2);

        }

        [TestMethod]
        public void DBGetUserByAddressAndName()
        {

            var testData = new FakeTablecs();

            testData.lista = new List<Table> { new Table { ime = "Bob", priimek = "Smith", naslov="Doma", Id=1 },
                new Table { ime = "loje", priimek = "Pišuka", naslov="Služba", Id=2 },
                new Table { ime = "Boris", priimek = "čižman", naslov="Internet", Id=3 },
                new Table { ime = "Peter", priimek = "Prevc", naslov="LJ", Id=4 } };

            var user = new Users(testData);

            var reslut = user.GetUserByAddresAndName("Služba", "loje");
            var reslut2 = user.GetUserByAddresAndName("rrrrrrr", "sadasdasd");
            Assert.AreEqual("Služba", reslut.naslov);
            Assert.AreEqual("loje", reslut.ime);
            Assert.IsNull(reslut2);
        }
    }
}
