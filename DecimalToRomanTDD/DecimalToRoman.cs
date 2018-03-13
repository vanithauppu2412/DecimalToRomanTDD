using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecimalToRomanTDD
{
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
