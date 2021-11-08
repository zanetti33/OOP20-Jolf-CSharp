using System;

namespace ZanziAlessandro
{ 

/**
 * Implements a moving object that updates is position each UPDATE_RATE milliseconds
 * @author loren
 *
 */
        public abstract class MovingObject : IMapObject
        {

	        public const long UPDATE_RATE = 20;
            public const double TO_SECONDS = 0.001;

            private bool stop;
            private long lastTimeUpdate;
            protected Point2D position;
            protected Vector2D speed;
            //protected Map map;

            /**
             * @param startingPos
             */
            public MovingObject(Point2D startingPos) : this(startingPos, Vector2D.NullVector())
            {
	          
            }

            /**
             * @param startingPos
             * @param startingSpeed
             */
            public MovingObject(Point2D startingPos, Vector2D startingSpeed)
            {
	            this.position = startingPos;
	            this.speed = startingSpeed;
	            this.stop = false;
            }

            /**
             * @return this object current position
             */
	        
            public Point2D GetPosition()
            {
	            return this.position;
            }

        /**
         * set the objects position
         * @param position
         */
            public void SetPosition(Point2D position)
            {
	            this.position = position;
            }

            /**
             * set the map in which the object is located
             * @param map
             */
            public void SetMap()
            {
	        
            }

            /**
             * is the default routine
             */
	        public void Run()
            {
            }

            /**
             * forces it to stop
             */
            public void ForceStop()
            {
	            this.stop = true;
            }

            /**
             * updates the object speed after timeElapsed milliseconds are passed
             * @param timeElapsed
             */
            protected abstract void UpdateSpeed(double timeElapsed);

            /**
             * applies constraints to this object
             */
            public abstract void ApplyConstraintTo();

            /**
             * @return if the object is moving
             */
            public bool IsMoving()
            {
	            return !speed.Equals(Vector2D.NullVector());
            }

            /**
             * @return this object current speed
             */
            public Vector2D GetSpeed()
            {
	            return this.speed;
            }

            /**
             * updates the object position after timeElapsed milliseconds are passed
             * @param timeElapsed
             */
            protected void UpdatePosition(double timeElapsed)
            {
	            this.position = (this.speed*(timeElapsed)).Translate(this.GetPosition());
            }

            /**
             *draw the object in a graphics object g
             */
	            public abstract void Draw();
	
        }

}