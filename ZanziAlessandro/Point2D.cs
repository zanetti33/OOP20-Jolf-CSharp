using System;
namespace ZanziAlessandro
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
	}
	public class Point2D
	{
		public double X { get; private set; }
		public double Y { get; private set; }
		public Point2D(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}
		public Point2D(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
		public static Point2D NullPoint()
		{
			return new Point2D(0, 0);
		}
		public int GetIntX()
		{
			return (int)this.X;
		}
		public int GetIntY()
		{
			return (int)this.Y;
		}
		public Point2D Translate(Vector2D vector)
		{
			return new Point2D(this.X + vector.X, this.Y + vector.Y);
		}
		public override String ToString()
		{
			return "Point2D [x=" + X + ", y=" + Y + "]";
		}
		public void SetLocation(Point2D newPoint)
		{
			X = newPoint.X;
			Y = newPoint.Y;
		}
		public Point ToPoint()
		{
			return new Point((int)this.X, (int)this.Y);
		}
	}
}
