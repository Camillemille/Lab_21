using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempConverter;

namespace TempTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(ConvertTemp.TempConvert(1, "c"), 1 * (9 / 5) + 32);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(ConvertTemp.TempConvert(1, "f"), (1 - 32) * (5 / 9));
        }
    }
}



