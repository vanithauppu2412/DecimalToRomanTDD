using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRomanTDD
{
    public class DecimalToRoman
    {
        public static String ConvertDecimalToRoman(int number)
        {
            if(number == 2)
            {
                return "II";
            }
            return "I";
        }
    }
    [TestClass]
    public class DecimalToRomanTest
    {
        [TestMethod]
        public void Two()
        {
            Assert.AreEqual("II", DecimalToRoman.ConvertDecimalToRoman(2));
        }
    }
}
