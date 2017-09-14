using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Converter
{
    public class RomanNumeralsConverter : INumeralsConverter
    {
        private static Dictionary<char, uint> RomanDigitsValues = new Dictionary<char, uint>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public uint Convert(string str)
        {
            if (!IsValidRomanNumerical(str))
                throw new ArgumentException("Invalid Roman numeral provided");

            if (string.IsNullOrEmpty(str))
                return 0;

            var convertedNumber = 0U;
            var prevDigitValue = RomanDigitsValues[str[0]];

            foreach (var symbol in str)
            {
                var currentVal = RomanDigitsValues[symbol];                                
                convertedNumber += currentVal;
                                
                if (currentVal > prevDigitValue)
                {
                    convertedNumber -= 2 * prevDigitValue;
                }
                prevDigitValue = currentVal;
            }
            return convertedNumber;
        }

        private bool IsValidRomanNumerical(string str)
        {
            var stage1 = @"I{0,3}";
            var stage2 = @"(V?" + stage1 + ")|(IV)";
            var stage3 = @"(X{0,3}(" + stage2 + ")?)|(IX)";
            var stage4 = @"(L?(" + stage3 + ")?)|(XL(" + stage2 + "|(IX))?)";
            var stage5 = @"(C{0,3}(" + stage4 + ")?)|(XC(" + stage2 + "|(IX))?)";
            var stage6 = @"(D?(" + stage5 + ")?)|(CD(" + stage4 + "|(XC))?)";
            var stage7 = @"(M*(" + stage6 + ")?)|(M*CM(" + stage4 + "|(XC))?)";

            var regex = new Regex(@"^(" + stage7 + ")$");
            return regex.IsMatch(str);
        }
    }
}
