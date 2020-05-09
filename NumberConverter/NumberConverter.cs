using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverterLib
{
    public class NumberConverter
    {
        Dictionary<int, string> oneDigitDict = new Dictionary<int, string>();
        Dictionary<int, string> twoDigitDict = new Dictionary<int, string>();
        Dictionary<int, string> tensDict = new Dictionary<int, string>();
        Dictionary<int, string> tensPowDict = new Dictionary<int, string>();

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

            while (len > 2)
            {
                int num = number[i] - '0';

                result.Append(oneDigitDict[num]);
                result.Append(" ");
                result.Append(tensPowDict[len - 1]);
                result.Append(" ");

                len--;
                i++;
            }
            while (len > 1)
            {
                int num = number[i] - '0';

                if (num > 1)
                {
                    result.Append(tensDict[num]);
                    result.Append(" ");
                }
                else if (num == 1)
                {
                    i++;
                    len--;
                    int key = num * 10 + number[i] - '0';
                    result.Append(twoDigitDict[key]);
                    result.Append(" ");
                }

                len--;
                i++;
            }
            while (len > 0)
            {
                int num = number[i] - '0';
                result.Append(oneDigitDict[num]);

                len--;
                i++;
            }
            return result.ToString().TrimEnd(' ');
        }

        private void Initialize()
        {
            OneDigitDictionaryIntialize();
            TwoDigitDictionaryIntialize();
            TensDictionaryIntialize();
            TensPowDictionaryIntialize();
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

        private void TwoDigitDictionaryIntialize()
        {
            twoDigitDict.Add(10, "ten");
            twoDigitDict.Add(11, "eleven");
            twoDigitDict.Add(12, "twelve");
            twoDigitDict.Add(13, "thirteen");
            twoDigitDict.Add(14, "foureen");
            twoDigitDict.Add(15, "fiveeen");
            twoDigitDict.Add(16, "sixeen");
            twoDigitDict.Add(17, "seveneen");
            twoDigitDict.Add(18, "eighteen");
            twoDigitDict.Add(19, "nineteen");
        }

        private void TensDictionaryIntialize()
        {
            tensDict.Add(2, "twenty");
            tensDict.Add(3, "thirty");
            tensDict.Add(4, "forty");
            tensDict.Add(5, "fifty");
            tensDict.Add(6, "sixty");
            tensDict.Add(7, "seventy");
            tensDict.Add(8, "eighty");
            tensDict.Add(9, "ninty");
        }

        private void TensPowDictionaryIntialize()
        {
            tensPowDict.Add(2, "hundred");
            tensPowDict.Add(3, "thousand");
        }
    }
}
