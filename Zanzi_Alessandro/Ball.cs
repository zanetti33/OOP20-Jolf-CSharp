using System;

using Zanzi_Alessandro.Point2D;

using Zanzi_Alessandro.Vector2D;

namespace Zanzi_Alessandro
{
	public class Ball : MovingObject
	{

		public const int DIAMETER = 15;
		public const int RADIUS = DIAMETER / 2;

		private const double DEFAULT_ACCELERATION = 10f;

		private static Color ballColor = Color.WHITE;
		private double acceleration;

		/**
		 * @param startingPos
		 */
		public Ball(Point2D startingPos)
		{
			super(startingPos);
			this.map = null;
		}

		/**
		 * sets the ball speed
		 * @param newSpeed
		 */
		[MethodImpl(MethodImplOptions.synchronized)]
		public void SetSpeed(Vector2D newSpeed)
		{
			this.speed = newSpeed;
			this.acceleration = DEFAULT_ACCELERATION;
		}

		/**
		 * sets the ball acceleration
		 * @param newAcc
		 */
		[MethodImpl(MethodImplOptions.synchronized)]
		public void SetAcceleration(double newAcc)
		{
			this.acceleration = newAcc;
		}

		/**
		 * @return the ball acceleration
		 */
		[MethodImpl(MethodImplOptions.synchronized)]
		public double GetAcceleration()
		{
			return this.acceleration;
		}

		/**
		 * sets the ball color
		 * @param newColor
		 */
		public static void SetColor(Color newColor)
		{
			ballColor = newColor;
		}
		
		public void Draw()
		{
		}

		[MethodImpl(MethodImplOptions.synchronized)]
		protected void UpdateSpeed(double timeElapsed)
		{
			double deltaV = this.GetAcceleration() * timeElapsed;
			if (this.GetSpeed().GetSquareModule() <= deltaV * deltaV)
			{
				this.speed = Vector2D.nullVector();
				this.acceleration = 0f;
			}
			else
			{
				this.speed = new Vector2D(this.GetSpeed().GetAngle(), GetSpeed().GetModule() - deltaV);
				this.acceleration = DEFAULT_ACCELERATION;
			}
		}

		[MethodImpl(MethodImplOptions.synchronized)]
		protected void ApplyConstraints()
		{
			this.map.GetObjects().stream()
			.filter(obj=> !obj.equals(this))
			.forEach(obj=>obj.ApplyConstraintTo(this));
			if (this.GetPosition().GetY() + RADIUS >= this.map.GetSize().GetHeight())
			{
				this.SetPosition(new Point2D(this.GetPosition().GetX(), this.map.GetSize().GetHeight() - RADIUS));
				this.speed = new Vector2D(this.GetSpeed().GetX(), -this.GetSpeed().GetY());
			}
			if (this.GetPosition().GetY() - RADIUS <= 0)
			{
				this.SetPosition(new Point2D(this.GetPosition().GetX(), RADIUS));
				this.speed = new Vector2D(this.GetSpeed().GetX(), -this.GetSpeed().GetY());
			}
			if (this.GetPosition().GetX() + RADIUS >= this.map.GetSize().GetWidth())
			{
				this.SetPosition(new Point2D(this.map.GetSize().GetWidth() - RADIUS, this.GetPosition().GetY()));
				this.speed = new Vector2D(-this.GetSpeed().GetX(), this.GetSpeed().GetY());
			}
			if (this.GetPosition().GetX() - RADIUS <= 0)
			{
				this.SetPosition(new Point2D(RADIUS, this.GetPosition().GetY()));
				this.speed = new Vector2D(-this.GetSpeed().GetX(), this.GetSpeed().GetY());
			}
		}

		//to implement if there are 2 or more balls in the same map simultaneously
		public void ApplyConstraintTo(Ball ball)
		{
		}

	}
}

