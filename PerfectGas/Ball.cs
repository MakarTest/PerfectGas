using System;
using System.Windows.Forms;

namespace PerfectGas
{
    public class Ball: PictureBox
    {
        static Random random;

        public double x, y;
        protected int radius;
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

        public void SetPicture(string fileName)
        {
            this.Load(fileName);
        }

        public void SetPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Show();
        }
    }
}
