using System;
using System.Windows.Forms;

namespace PerfectGas
{
    class MoveBall : Ball
    { 
        double vx = -5, vy = -5;
        Timer timer;

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

        public void Move()
        {
            x = x + vx;
            y = y + vy;
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
    
    }
}
