using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse_Integer;

namespace Reverse_IntegerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution solution = new Solution();
            Assert.AreEqual(321, solution.Reverse(123));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution solution = new Solution();
            Assert.AreEqual(-321, solution.Reverse(-123));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Solution solution = new Solution();
            Assert.AreEqual(21, solution.Reverse(120));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Solution solution = new Solution();
            Assert.AreEqual(0, solution.Reverse(-2147483648));
        }
    }
}
