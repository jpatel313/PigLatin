using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]//attribute to run as a test
        public void TestMethod0()
        {
            int index = lab6_real.PigLatinProgram.FirstVowelMethod("exit");
            //int index made for testing, namespace.class.method(input variable)
            Assert.AreEqual(0,index);//index should = 0
        }

        [TestMethod]//attribute to run as a test
        public void TestMethod1()
        {
            int index = lab6_real.PigLatinProgram.FirstVowelMethod("corner");
            //int index made for testing, namespace.class.method(input variable)
            Assert.AreEqual(1, index);//index should = 0
        }

      /*  [TestMethod]//attribute to run as a test
        public void TestMethodT1()
        {
            int index = lab6_real.PigLatinProgram.TranslateMethod("189");
            //int index made for testing, namespace.class.method(input variable)
            Assert.AreEqual(189, index);//index should = 0
        }

        [TestMethod]//attribute to run as a test
        public void TestMethodT2()
        {
            int index = lab6_real.PigLatinProgram.TranslateMethod("hello@grandcircus.co");
            //int index made for testing, namespace.class.method(input variable)
            Assert.AreEqual("hello@grandcircus.co", index);//index should = 0
        }

        [TestMethod]//attribute to run as a test
        public void TestMethodT3()
        {
            int index = lab6_real.PigLatinProgram.TranslateMethod("can't");
            //int index made for testing, namespace.class.method(input variable)
            Assert.AreEqual("can't", index);//index should = 0
        }
        */

    }
}
