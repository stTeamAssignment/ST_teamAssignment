using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STAssign1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Item item = Program.GetObject();
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Item item = Program.GetObject();
            Assert.IsTrue(typeof(Item).IsInstanceOfType(item));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Item item = Program.GetObject();
            item.Description = "This is a test description";
            item.ItemNumber = 1;
            item.Weight = 10;
            item.UnitOfMeasure = Item.Measures.BOX;
            string itemOutput = Program.PrintOutItem(item);
            Assert.AreEqual("Item Number: 1\nDescription: This is a test description\nUnit of Measure: BOX\nWeight: 10", itemOutput);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Item item = Program.GetObject();
            item.Description = "Test4";
            item.ItemNumber = 0;
            item.Weight = 1;
            item.UnitOfMeasure = Item.Measures.EACH;
            string itemOutput = Program.PrintOutItem(item);
            Assert.AreEqual("Item Number: 0\nDescription: Test4\nUnit of Measure: EACH\nWeight: 1", itemOutput);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Item item = Program.GetObject();
            item.Description = "Test5";
            item.ItemNumber = 5;
            item.Weight = 5;
            item.UnitOfMeasure = Item.Measures.GALLON;
            string itemOutput = Program.PrintOutItem(item);
            Assert.AreEqual("Item Number: 5\nDescription: Test5\nUnit of Measure: GALLON\nWeight: 5", itemOutput);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Item item = Program.GetObject();
            item.Description = "Test6";
            item.ItemNumber = 6;
            item.Weight = 6;
            item.UnitOfMeasure = Item.Measures.POUND;
            string itemOutput = Program.PrintOutItem(item);
            Assert.AreEqual("Item Number: 6\nDescription: Test6\nUnit of Measure: POUND\nWeight: 6", itemOutput);
        }
    }
}
