using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PerfectGas
{
    public class MoveBall : Ball
    { 
        protected double vx = -5, vy = -5;
        protected double friction = 0.99;
        protected Timer timer;
        protected List<Ball> collisionObjects = new List<Ball>();

        public MoveBall(int x, int y, Form form) : base(x, y, form)
        { 
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
            Show();
        }

        public virtual void Move()
        {
            vx = vx * friction;
            vy = vy * friction;
            x = x + vx;
            y = y + vy;
            foreach (var collisionObject in collisionObjects)
            {
                double distance = Math.Sqrt(Math.Pow((this.x - collisionObject.x), 2) + Math.Pow((this.y - collisionObject.y), 2));
                if (distance < 2 * this.radius)
                {
                    vx = this.x - collisionObject.x;
                    vy = this.y - collisionObject.y;
                }
            }

            if (y < 0) vy = -vy;
            if (x < 0) vx = -vx;
            if (y > form.Height) vy = -vy;
            if (x > form.Width) vx = -vx;
        }

        public void SetSpeed(int v, double alpha)
        {
            vx = v * Math.Cos(alpha);
            vy = v * Math.Sin(alpha);
        }

        public void SetObjectCollision(Ball collisionObject)
        {
            collisionObjects.Add(collisionObject);
        }

    }
}
