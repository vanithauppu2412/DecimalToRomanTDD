using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRomanTDD
{
    public class DecimalToRoman
    {
        public static String ConvertDecimalToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;
            if (remaining == 9)
            {
                result.Append("IX");
                remaining -= 9;
            }
            if (remaining >= 5)
            {
                result.Append("V");
                remaining -= 5;
            }
            if (remaining == 4)
            {
                result.Append("IV");
                remaining -= 4;
            }
            for (int i = 0; i < remaining; i++)
            {
                result.Append("I");
            }
            return result.ToString();
        }
    }
    [TestClass]
    public class DecimalToRomanTest
    {
        [TestMethod]
        public void TestMethod()
        {
            //Assert.AreEqual("V", DecimalToRoman.ConvertDecimalToRoman(5));
            //Assert.AreEqual("VI", DecimalToRoman.ConvertDecimalToRoman(6));
            //Assert.AreEqual("VII", DecimalToRoman.ConvertDecimalToRoman(7));
            //Assert.AreEqual("VIII", DecimalToRoman.ConvertDecimalToRoman(8));
            Assert.AreEqual("IX", DecimalToRoman.ConvertDecimalToRoman(9));

        }
    }
}
