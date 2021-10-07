using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using assignment;

namespace testarea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            int length = 20;
            int width = 10;

            int length2 = 10;
            int width2 = 5;

            var test1 = new rectangle(length, width);
            var test2 = new rectangle(length2, width2);
            Assert.AreEqual(200, test1.getarea());
            Assert.AreEqual(50, test2.getarea());
        }

        }
    }

