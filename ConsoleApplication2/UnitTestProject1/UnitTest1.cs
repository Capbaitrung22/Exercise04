using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil(2.3f);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result2);

        }
        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor(-2.3f);
            Assert.AreEqual(-3, result2);
        }
    }
}
