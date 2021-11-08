using System;

namespace ZanziAlessandro
{
	public class Ball : MovingObject
	{

		public const int DIAMETER = 15;
		public const int RADIUS = DIAMETER / 2;

		private const double DEFAULT_ACCELERATION = 10f;

		//private static Color ballColor = Color.WHITE;
		private double acceleration;

		/**
		 * @param startingPos
		 */
		public Ball(Point2D startingPos) : base(startingPos)
		{
			
		}

		/**
		 * sets the ball speed
		 * @param newSpeed
		 */
		public void SetSpeed(Vector2D newSpeed)
		{
			this.speed = newSpeed;
			this.acceleration = DEFAULT_ACCELERATION;
		}

		/**
		 * sets the ball acceleration
		 * @param newAcc
		 */
		public void SetAcceleration(double newAcc)
		{
			this.acceleration = newAcc;
		}

		/**
		 * @return the ball acceleration
		 */
		public double GetAcceleration()
		{
			return this.acceleration;
		}

		/**
		 * sets the ball color
		 * @param newColor
		 */
		public static void SetColor()
		{
		}

		public override void Draw()
        {

        }

		protected override void UpdateSpeed(double timeElapsed)
		{
			double deltaV = this.GetAcceleration() * timeElapsed;
			if (this.GetSpeed().GetSquareModule() <= deltaV * deltaV)
			{
				this.speed = Vector2D.NullVector();
				this.acceleration = 0f;
			}
			else
			{
				this.speed = new Vector2D(this.GetSpeed().GetAngle(), GetSpeed().GetModule() - deltaV);
				this.acceleration = DEFAULT_ACCELERATION;
			}
		}

		public override void ApplyConstraintTo()
		{
			
		}

		//to implement if there are 2 or more balls in the same map simultaneously
		public void ApplyConstraintTo(Ball ball)
		{
		}

	}
}

