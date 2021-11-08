using System;

namespace ZanziAlessandro
{
    public class Sand : Surface
    {
        private const double sandFriction = 50;

        public Sand(Point2D position, int width, int height)
            : base(position, width, height, sandFriction) { }
    }
}