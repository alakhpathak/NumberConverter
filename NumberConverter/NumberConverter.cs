using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverterLib
{
    public class NumberConverter
    {
        Dictionary<int, string> oneDigitDict = new Dictionary<int, string>();

        public NumberConverter()
        {
            Initialize();
        }
        public string ToWord(int n)
        {
            StringBuilder result = new StringBuilder();

            string number = n.ToString();
            int len = number.Length;
            int i = 0;

            while (len > 0)
            {
                result.Append(oneDigitDict[number[i] - '0']);
                len--;
                i++;
            }
            return result.ToString();
        }

        private void Initialize()
        {
            OneDigitDictionaryIntialize();
        }

        private void OneDigitDictionaryIntialize()
        {
            oneDigitDict.Add(0, "zero");
            oneDigitDict.Add(1, "one");
            oneDigitDict.Add(2, "two");
            oneDigitDict.Add(3, "three");
            oneDigitDict.Add(4, "four");
            oneDigitDict.Add(5, "five");
            oneDigitDict.Add(6, "six");
            oneDigitDict.Add(7, "seven");
            oneDigitDict.Add(8, "eight");
            oneDigitDict.Add(9, "nine");
        }
    }
}
