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
    public class GostTests
    {
        [TestMethod()]
        public void TocanFormatOsobne_Test1()
        {
            Assert.IsTrue(Gost.TocanFormatOsobne(11112222));
        }

        [TestMethod()]
        public void TocanFormatOsobne_Test2()
        {
            Assert.IsFalse(Gost.TocanFormatOsobne(0));
        }

        [TestMethod()]
        public void TocanFormatOsobne_Test3()
        {
            Assert.IsFalse(Gost.TocanFormatOsobne(1111222));
        }
    }
}