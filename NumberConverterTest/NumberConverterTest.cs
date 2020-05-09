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
        public void ZeroTest_NoError()
        {
            string expected = "zero";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(0);
            StringAssert.Equals(expected, expected);
        }

        [TestMethod]
        public void SingleTest_NoError()
        {
            string expected = "six";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(6);
            StringAssert.Equals(expected, expected);
        }

        [TestMethod]
        public void TwoDigitTest_NoError()
        {
            string expected = "thirteen";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(13);
            StringAssert.Equals(expected, expected);
        }

        [TestMethod]
        public void TwoDigitMaxTest_NoError()
        {
            string expected = "fifty seven";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(57);
            StringAssert.Equals(expected, expected);
        }

        [TestMethod]
        public void TwoDigitZeroTest_NoError()
        {
            string expected = "fifty";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(50);
            StringAssert.Equals(expected, expected);
        }


        [TestMethod]
        public void FourDigitTest_NoError()
        {
            string expected = "one thousand two hundred thirty four";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(1234);
            StringAssert.Equals(expected, expected);
        }

        [TestMethod]
        public void FourDigitContainsZeroTest_NoError()
        {
            string expected = "one thousand thirty four";
            NumberConverter numberConverter = new NumberConverter();
            var actual = numberConverter.ToWord(1034);
            StringAssert.Equals(expected, expected);
        }
    }
}
