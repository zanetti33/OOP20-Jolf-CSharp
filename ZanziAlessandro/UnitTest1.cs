using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZanziAlessandro
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAcceleration()
        {
            Ball b = new Ball(new Point2D(3.1, 3.2));
            b.SetAcceleration(2);
            Assert.AreEqual(2, b.GetAcceleration());
        }
        [TestMethod]
        public void TestSurface()
        {
            Ball b1 = new Ball(new Point2D(3.1, 3.2));
            Surface s = new Sand(new Point2D(2, 2), 3, 3);
            Assert.IsTrue(s.Contains(b1.GetPosition()));
            b1.SetAcceleration(s.GetFriction());
            Assert.AreEqual(b1.GetAcceleration(), 50);
        }
    }
}
