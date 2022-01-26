using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    /// <summary>
    /// Class test
    /// </summary>
    [TestClass()]
    public class EuclideAlgorithmTests
    {
        /// <summary>
        /// Test method GCD of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="gcd"></param>
        [TestMethod()]
        [DataRow(99, 123, 3)]
        [DataRow(99, -123, 3)]
        [DataRow(41, 6, 1)]
        public void GCDTest(int a, int b, int gcd)
        {
            EuclideAlgorithm euclideAlgorithm = new EuclideAlgorithm();
            Assert.AreEqual(euclideAlgorithm.GCD(a, b, out int spentTime), gcd);
        }
        /// <summary>
        /// Test method GCD of three integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="gcd"></param>
        [TestMethod()]
        [DataRow(99, 999, 81, 9)]
        [DataRow(99, -123, 3, 3)]
        [DataRow(41, 6, 256, 1)]
        public void GCDTest_2(int a, int b, int c, int gcd)
        {
            EuclideAlgorithm euclideAlgorithm = new EuclideAlgorithm();
            Assert.AreEqual(euclideAlgorithm.GCD(a, b, c), gcd);
        }
        /// <summary>
        /// Test method GCD of four integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="gcd"></param>
        [TestMethod()]
        [DataRow(99, 123, 3, 54, 3)]
        [DataRow(99, -123, 3, 5126, 1)]
        [DataRow(41, 6, 1, 222, 1)]
        public void GCDTest_3(int a, int b, int c, int d, int gcd)
        {
            EuclideAlgorithm euclideAlgorithm = new EuclideAlgorithm();
            Assert.AreEqual(euclideAlgorithm.GCD(a, b, c, d), gcd);
        }
        /// <summary>
        /// Test method Binary GCD of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="gcd"></param>
        [TestMethod()]
        [DataRow(99, 123, 3)]
        [DataRow(99, -123, 3)]
        [DataRow(-41, 6, 1)]
        public void BinaryGCDTest(int a, int b, int gcd)
        {
            EuclideAlgorithm euclideAlgorithm = new EuclideAlgorithm();
            Assert.AreEqual(euclideAlgorithm.BinaryGCD(a, b, out int spentTime), gcd);
        }
    }
}