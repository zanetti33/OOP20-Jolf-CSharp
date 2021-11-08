using System;

namespace ZanziAlessandro
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

        public double GetFriction()
        {
            return this.friction;
        }

        public bool Contains(Point2D point)
        {
            if(point.GetIntX() >= this.position.GetIntX() && 
                point.GetIntX() <= (this.position.GetIntX() + this.width) &&
                point.GetIntY() >= this.position.GetIntY() &&
                point.GetIntY() <= (this.position.GetIntY() + this.height))
            {
                return true;
            }
            return false;
        }
        public void Draw() { }
        public void ApplyConstraintTo() { }
    }
}