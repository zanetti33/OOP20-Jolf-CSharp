using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ZanettiLorenzo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTest()
        {
            int x = 3;
            Assert.IsTrue(x == 3);
            double a = MyMath.ToDegrees(Math.PI / 2);
            Assert.AreEqual(a, 90);
        }

        [TestMethod]
        public void TestPoint2D()
        {
            Point2D p1 = new Point2D(12.3, 7.5);
            Point2D p2 = Point2D.NullPoint();
            Assert.AreEqual(p1.GetIntX(), 12);
            p1.SetLocation(p2);
            Assert.IsTrue(p1.X == 0 && p1.Y == 0);
        }

        [TestMethod]
        public void TestAngle()
        {
            Angle a1 = Angle.OfDegrees(45);
            Angle a2 = Angle.OfLine(0, 0, 33, 33);
            Assert.AreEqual(a1, a2);
            Angle a3 = a2.Inverse();
            Assert.AreEqual(225, a3.Degrees);
        }

        [TestMethod]
        public void TestVector2D()
        {
            Vector2D v1 = new Vector2D(8.7, 2.2);
            Vector2D v2 = new Vector2D(0, 0, -1.3, -7.8);
            Point2D p = new Point2D(0, 0);
            p = v1.Translate(p);
            Assert.AreEqual(p.X, 8.7);
            v2 = v2.GetOppositeVector();
            Vector2D v3 = v1 + v2;
            Assert.AreEqual(v3.GetSquareModule(), 200);
            v3 *= 2;
            Assert.AreEqual(v3.GetSquareModule(), 800);
        }
    }
}