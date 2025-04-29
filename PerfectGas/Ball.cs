using System;
using System.Windows.Forms;

namespace PerfectGas
{
    class Ball: PictureBox
    {
        static Random random;

        protected double x, y;
        int radius;
        protected Form form;

        public Ball()
        {
            random  = new Random();
            this.x = random.Next(400);
            this.y = random.Next(400);
            this.radius = 20;
            this.Load("images/red_ball.png");
            this.Width = 2 * radius;
            this.Height = 2 * radius;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Ball(int x, int y, Form form):this()
        {
            this.x = x;
            this.y = y;
            this.form = form;
            this.form.Controls.Add(this);
            Show();
        }

        public void Show()
        {
            this.Top = (int)y - radius;
            this.Left = (int)x - radius;
        }
    }
}
