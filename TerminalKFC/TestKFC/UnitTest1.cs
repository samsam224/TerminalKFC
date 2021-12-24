using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KFC;
using KFC.Windows;

namespace TestKFC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrice()
        {
            var p = new Page3();
            Assert.IsTrue(p.GainProduct(300, "Баскет"));
            Assert.IsTrue(p.GainProduct(999, "Комбо"));
            Assert.IsTrue(p.GainProduct(1, "Салфетка"));
            Assert.IsFalse(p.GainProduct(0, "123"));
            Assert.IsFalse(p.GainProduct(-50, "-"));
            Assert.IsFalse(p.GainProduct(-950, "None"));
        }

        [TestMethod]
        public void TestAcceptOrder()
        {
            var p = new Page3();
            Assert.IsTrue(p.AcceptOrder(500, 250));
            Assert.IsTrue(p.AcceptOrder(1000, 500));
            Assert.IsFalse(p.AcceptOrder(20, 140));
            Assert.IsFalse(p.AcceptOrder(0, 100));
        }
    }
}
