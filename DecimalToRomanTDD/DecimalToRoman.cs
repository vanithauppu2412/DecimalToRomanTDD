using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRomanTDD
{
    public class DecimalToRoman
    {
        private static int[] Numerals = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static String[] RomanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public static String ConvertDecimalToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;
            for (int i = 0; i < Numerals.Length; i++)
            {
               remaining = appendRomanNumerals(remaining, Numerals[i], RomanSymbols[i], result);
            }
            return result.ToString();
        }
        private static int appendRomanNumerals(int num, int value, String romanDigits, StringBuilder builder)
        {
            int result = num;
            while (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }
            return result;
        }
    }
        [TestClass]
    public class DecimalToRomanTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("MMXVI", DecimalToRoman.ConvertDecimalToRoman(2016));

        }
    }
}
