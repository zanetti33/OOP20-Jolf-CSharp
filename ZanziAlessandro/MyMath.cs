using System;

public class MyMath
{
	public static double ToRadians(double degrees)
    {
        return degrees * Math.PI / 180;
    }
    public static double ToDegrees(double radians)
    {
        return radians * 180 / Math.PI;
    }
}
