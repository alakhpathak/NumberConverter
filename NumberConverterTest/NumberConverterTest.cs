using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverterLib;
using System;

namespace NumberConverterTest
{
    [TestClass]
    public class NumberConverterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "whole number is expected")]
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
            StringAssert.Contains(expected, expected);
        }

        [TestMethod]
        public void TwoDigitTest_NoError()
        {
            string expected = "thirteen";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(13);
            StringAssert.Contains(expected, expected);
        }

        [TestMethod]
        public void TwoDigitMaxTest_NoError()
        {
            string expected = "fifty seven";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(57);
            StringAssert.Contains(expected, expected);
        }


        [TestMethod]
        public void FourDigitTest_NoError()
        {
            string expected = "One thousand two hundred thirty four";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(1234);
            StringAssert.Contains(expected, expected);
        }
    }
}
