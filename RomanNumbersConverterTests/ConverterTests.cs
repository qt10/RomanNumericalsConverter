using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter;

namespace ConverterTests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_N_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("N");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_VX_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("VX");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_VV_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("VV");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_VIV_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("VIV");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_IXV_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("IXV");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_XCL_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("XCL");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_MID_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("MID");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_IVI_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("IVI");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_IIV_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("IIV");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Convert_CMD_ThrowsException()
        {
            var numbersConverter = new RomanNumeralsConverter();
            numbersConverter.Convert("CMD");
        }

        [TestMethod]
        public void Convert_EmptyString_ReturnsZero()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(0U, numbersConverter.Convert(string.Empty));
        }

        [TestMethod]
        public void Convert_I_ReturnsOne()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(1U, numbersConverter.Convert("I"));
        }

        [TestMethod]
        public void Convert_II_ReturnsTwo()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(2U, numbersConverter.Convert("II"));
        }

        [TestMethod]
        public void Convert_IV_ReturnsFour()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(4U, numbersConverter.Convert("IV"));
        }

        [TestMethod]
        public void Convert_V_ReturnsFive()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(5U, numbersConverter.Convert("V"));
        }

        [TestMethod]
        public void Convert_VII_ReturnsSeven()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(7U, numbersConverter.Convert("VII"));
        }

        [TestMethod]
        public void Convert_IX_ReturnsNine()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(9U, numbersConverter.Convert("IX"));
        }

        [TestMethod]
        public void Convert_XIV_ReturnsFourteen()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(14U, numbersConverter.Convert("XIV"));
        }

        [TestMethod]
        public void Convert_LXXVIII_ReturnsSeventyEight()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(78U, numbersConverter.Convert("LXXVIII"));
        }

        [TestMethod]
        public void Convert_CLXXXIV_ReturnsOneHundredEightyFour()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(184U, numbersConverter.Convert("CLXXXIV"));
        }

        [TestMethod]
        public void Convert_CDLXVI_ReturnsFourHundredSixtySix()
        {
            var numbersConverter = new RomanNumeralsConverter();
            Assert.AreEqual(466U, numbersConverter.Convert("CDLXVI"));
        }


    }
}
