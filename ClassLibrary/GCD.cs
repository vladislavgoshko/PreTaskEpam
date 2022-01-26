using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ClassLibrary
{
    /// <summary>
    /// Type for finding GCD
    /// </summary>
    public class EuclideAlgorithm
    {
        /// <summary>
        /// Method for calculating the GCD of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="spentTime">Spent time of calculating algorithm</param>
        /// <returns>GCD</returns>
        public int GCD(int a, int b, out int spentTime)
        {
            if (a == 0 || b == 0)
                throw new Exception("One of the numbers is zero");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            stopwatch.Stop();
            spentTime = (int)stopwatch.ElapsedMilliseconds;
            return a + b;
        }
        /// <summary>
        /// Overloaded method GCD of three integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>GCD of three integers</returns>
        public int GCD(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
                throw new Exception("One of the numbers is zero");
            return GCD(GCD(a, b, out int spentTime), c, out spentTime);
        }
        /// <summary>
        /// Overloaded method GCD of four integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int GCD(int a, int b, int c, int d)
        {
            if (a == 0 || b == 0 || c == 0 || d == 0)
                throw new Exception("One of the numbers is zero");

            return GCD(GCD(a, b, out int spentTime), GCD(c, d, out spentTime), out spentTime);
        }
        /// <summary>
        /// Method Binary GCD of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="spentTime"></param>
        /// <returns>GCD</returns>
        public int BinaryGCD(int a, int b, out int spentTime)
        {
            if (a == 0 || b == 0)
                throw new Exception("One of the numbers is zero");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            a = Math.Abs(a);
            b = Math.Abs(b);
            int k = 1;
            while ((a != 0) && (b != 0))
            {
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a /= 2;
                    b /= 2;
                    k *= 2;
                }
                while (a % 2 == 0) a /= 2;
                while (b % 2 == 0) b /= 2;
                if (a >= b) a -= b;
                else b -= a;
            }
            stopwatch.Stop();
            spentTime = (int)stopwatch.ElapsedMilliseconds;
            return b * k;
        }
        /// <summary>
        /// Method launchimg methods with different algorithms
        /// </summary>
        /// <param name="spentTimeEuclide"></param>
        /// <param name="spentTimeBinaryGCD"></param>
        public void GetSpentTimeMethods(out int spentTimeEuclide, out int spentTimeBinaryGCD)
        {
            GCD(222222, 111111, out spentTimeEuclide);
            BinaryGCD(222222, 111111, out spentTimeBinaryGCD);
        }
    }
}
