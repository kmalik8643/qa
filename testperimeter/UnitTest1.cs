using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using assignment;

namespace testperimeter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int length = 20;
            int width = 10;

            int length2 = -2;
            int width2 = -3;

            int length3 = 0;
            int width3 = 0;
            
            var test1 = new rectangle(length, width);
            var test2 = new rectangle(length2, width2);
            var test3 = new rectangle(length3, width3);

            Assert.AreEqual(60, test1.getperimeter());
            Assert.AreEqual(0, test2.getperimeter());
            Assert.AreEqual(0, test3.getperimeter());

        }
    }
}
