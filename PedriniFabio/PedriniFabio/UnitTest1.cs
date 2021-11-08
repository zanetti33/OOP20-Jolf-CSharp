using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PedriniFabio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIce()
        {
            Ice zone = new Ice(new Point2D(2, 5), 20, 20);
            Point2D point = new Point2D(12, 10);
            Assert.IsTrue(zone.Contains(point));
        }

        [TestMethod]
        public void TestSand()
        {
            Sand zone = new Sand(new Point2D(22, 58), 30, 30);
            Point2D point1 = new Point2D(12, 10);
            Assert.IsFalse(zone.Contains(point1));
            Point2D point2 = new Point2D(46, 60);
            Assert.IsTrue(zone.Contains(point2));
        }

        [TestMethod]
        public void TestFriction()
        {
            Ice ice = new Ice(new Point2D(2, 5), 20, 20);
            Sand sand = new Sand(new Point2D(22, 58), 30, 30);
            Assert.AreEqual(0.9, ice.GetFriction());
            Assert.AreEqual(50, sand.GetFriction());
        }
    }
}
