using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Learning_about_testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLeapYear2001()
        {
            Assert.IsFalse(LeapYear.IsLeapYear(2001));




        }
        public void TestLeapYear2000()
        {
            Assert.IsTrue(LeapYear.IsLeapYear(2000));
        }
        [TestMethod]
        public void TestLeapYear1900()
        {
            Assert.IsFalse(LeapYear.IsLeapYear(1900));



        }





        [TestMethod]
        public void TestLeapYear1992()
        {
            Assert.IsTrue(LeapYear.IsLeapYear(1992));
        }
        [TestMethod]
        public void TestAdd1()
        {
            Assert.AreEqual(DoSomeMath.Add(1, 2), 3);
        }
        [TestMethod]
        public void TestLeapYearAndAdd()
        {
            int myAdd = DoSomeMath.Add(1900, 92);
            bool myLeapYearCheck = LeapYear.IsLeapYear(myAdd);
            Assert.IsTrue(myLeapYearCheck);
        }




                

            
       

    }
}
