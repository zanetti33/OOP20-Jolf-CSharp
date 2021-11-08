using System;
namespace ZanettiLorenzo;
public class Vector2D
{
	public double X { get; private set; }
	public double Y { get; private set; }
	public Vector2D(double x, double y)
    {
		this.X = x;
		this.Y = y;
    }
	public Vector2D(Point p1, Point p2) : this(p2.X - p1.X, p2.Y - p1.Y) { }
	public Vector2D(Point2D p1, Point p2) : this(p2.X - p1.X, p2.Y - p1.Y) { }
	public Vector2D(double x1, double y1, double x2, double y2) : this(x2 - x1, y2 - y1) { }
	public Vector2D(Angle angle, double module)
	{
		this.X = Math.Cos(angle.Radians) * module;
		this.Y = Math.Sin(angle.Radians) * module;
	}
	public static Vector2D operator+(Vector2D v1, Vector2D v2)
    {
		return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }
	public static Vector2D operator*(Vector2D v, double a)
	{
		return new Vector2D(v.X * a, v.Y * a);
	}
	public static Vector2D NullVector()
	{
		return new Vector2D(0, 0);
	}
	public Vector2D GetOppositeVector()
    {
		return new Vector2D(-this.X, -this.Y);
    }
	public double GetModule()
    {
		return Math.Sqrt(this.GetSquareModule());
    }
    public double GetSquareModule()
    {
        return this.X * this.X + this.Y * this.Y;
    }
	public Angle GetAngle()
    {
		return Angle.OfRadians(Math.Atan2(this.Y, this.X));
    }
	public Point Translate(Point p)
    {
		return new Point(p.X + (int)this.X, p.Y + (int)this.Y);
    }
	public Point2D Translate(Point2D p)
    {
		return new Point2D(p.X + this.X, p.Y + this.Y);
    }
	public override String ToString()
	{
		return "Vector2D [x=" + X + ", y=" + Y + "]";
	}
    public override bool Equals(object? obj)
    {
        return obj is Vector2D d &&
               X == d.X &&
               Y == d.Y;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}
