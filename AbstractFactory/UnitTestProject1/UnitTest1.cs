using System;
using System.Runtime.Remoting;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethodJensen()
        {
            var testJensenFactory = new JensenFactory();



            var test = testJensenFactory.CreateEducation();
            int expected = 34;
            int actual = test.NumberOfStudents;

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestMethodNackademin()
        {
            var testNackademinFactory = new NackademinFactory();

            var test = testNackademinFactory.CreateEducation();
            int expected = 25;
            int actual = test.NumberOfStudents;
            Assert.AreEqual(expected, actual);
        }
    }
}
