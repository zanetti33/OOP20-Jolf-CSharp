using System;

namespace PedriniFabio
{
    public abstract class Surface : IMapObject
    {
        private double friction;
        private Point2D position;
	    private int width;
        private int height;

        public Surface(Point2D position, int width, int height, double friction)
        {
            this.position = position;
            this.width = width;
            this.height = height;
            this.friction = friction;
        }

        public Point2D GetPosition()
        {
            return this.position;
        }
        public void Draw() { }
        public void ApplyConstraintTo() { }
    }
}