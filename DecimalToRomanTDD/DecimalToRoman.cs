using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRomanTDD
{
    public class DecimalToRoman
    {
        public static String ConvertDecimalToRoman(int arabic)
        {
            return "I";
        }
    }
    [TestClass]
    public class DecimalToRomanTest
    {
        [TestMethod]
        public void one()
        {
            Assert.AreEqual("I", DecimalToRoman.ConvertDecimalToRoman(1));
        }
    }
}
