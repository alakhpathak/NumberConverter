using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterLib;
using System;

namespace NumberConverterTest
{
    [TestClass]
    public class NumberConverterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNumberNotSupportedTest_Error()
        {
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(-5);
        }

        [TestMethod]
        public void SingleDigitTest_NoError()
        {
            string expected = "zero";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(0);
            Assert.AreEqual(expected, expected);
        }

        [TestMethod]
        public void TwoDigitTest_NoError()
        {
            string expected = "thirteen";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(13);
            Assert.AreEqual(expected, expected);
        }

        [TestMethod]
        public void FourDigitTest_NoError()
        {
            string expected = "One thousand two hundred thirty four";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(1234);
            Assert.AreEqual(expected, expected);
        }
    }
}
