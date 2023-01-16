using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPI_Restoran.Data.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPI_Restoran.Data.Other.Tests
{
    [TestClass()]
    public class StolTests
    {
        [TestMethod()]
        public void IntervalTest_1()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(12, 14, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_2()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(11, 14, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_3()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(12, 15, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_4()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(12, 14, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_5()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(13, 15, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_6()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(14, 15, 12, 14));
        }

        [TestMethod()]
        public void IntervalTest_7()
        {
            Assert.IsTrue(Stol.IntervalTestMethod(13, 14, 12, 14));
        }
    }
}