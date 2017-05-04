using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace multiplicate.Tests
{
    [TestClass]
    public class MultPolinomTests
    {
        [TestMethod]
        public void Mult_1_2_3_and_4_5_returned_4_13_22_15()
        {
            double[] kpol = { 1, 2, 3 };
            double[] kpol2 = { 4, 5 };
            Polinom pol = new Polinom(2, kpol);
            Polinom pol2 = new Polinom(1, kpol2);

            double[] kexpected = { 4, 13, 22, 15 };
            Polinom expected = new Polinom(3, kexpected);

            Assert.AreEqual(expected.ToString(), MultPolinom.Multiplication(pol, pol2).ToString());
        }
    }
}
