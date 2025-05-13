using PerfectGas;
using System;
using System.Windows.Forms;


namespace AeroHockey1
{
    internal class Puck:MoveBall
    {
        EngineGame game;
        int startX, startY;
        public Puck(int x, int y, Form form, EngineGame score):base(x, y, form)
        {
            startX = x;
            startY = y;
            this.Stop();
            this.SetPicture("images/blue_puck.png");
            this.game = score;
        }
        public void Stop()
        { 
            timer.Stop();
        }
        public void Start()
        { 
            timer.Start(); 
        }

        public override void Move()
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
            int heightGates = form.Height / 3;

            if (y < 0) vy = -vy;
            if (x < 0)
                if (y > heightGates && y < 2 * heightGates)
                {
                    game.IncreaseLeftUserScore();
                    x = startX;
                    y = startY;
                    game.Start();
                }
                else
                    vx = -vx;
            if (y > form.Height) vy = -vy;
            if (x > form.Width) vx = -vx;
        }
    }
}
