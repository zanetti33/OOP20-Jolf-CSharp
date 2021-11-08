using System;

namespace PedriniFabio
{
    public class Ice : Surface
    {
        private const double iceFriction = 0.9;

        public Ice(Point2D position, int width, int height) 
            : base(position, width, height, iceFriction){ }
    }
}