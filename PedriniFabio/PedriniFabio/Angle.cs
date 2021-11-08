using System;
/*
 * Scritto da Zanetti Lorenzo
 */
namespace PedriniFabio
{
	public class Angle
	{
		private const double RADIANS_FULL_LOOP = Math.PI * 2;
		private const double DEGREES_FULL_LOOP = 360.0;

		public double Degrees { get; private set; }
		public double Radians { get; private set; }
		public Angle(double degrees, double radians)
		{
			this.Degrees = degrees;
			this.Radians = radians;
		}
		public static Angle OfRadians(double radians)
		{
			double newRadians = radians % RADIANS_FULL_LOOP;
			return new Angle(MyMath.ToDegrees(newRadians), newRadians);
		}
		public static Angle OfDegrees(double degrees)
		{
			double newDegrees = degrees % DEGREES_FULL_LOOP;
			return new Angle(newDegrees, MyMath.ToRadians(newDegrees));
		}
		public static Angle OfLine(double x1, double y1, double x2, double y2)
		{
			return Angle.OfRadians(Math.Atan2(y2 - y1, x2 - x1));
		}
		public Angle Inverse()
		{
			return Angle.OfDegrees(this.Degrees + 180);
		}
		public override String ToString()
		{
			return "Angle [degrees=" + Degrees + ", radians=" + Radians + " rads]";
		}
		#nullable enable
		public override bool Equals(object? obj)
		{
			return obj is Angle angle &&
				   Degrees == angle.Degrees &&
				   Radians == angle.Radians;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Degrees, Radians);
		}
	}

}
