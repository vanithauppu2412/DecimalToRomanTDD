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
            for (int i = 0; i < number; i++)
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
        public void Five()
        {
            Assert.AreEqual("V", DecimalToRoman.ConvertDecimalToRoman(5));
           
        }
    }
}
