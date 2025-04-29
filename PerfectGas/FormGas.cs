using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectGas
{
    public partial class FormGas : Form
    {
        Random rnd = new Random();
        public FormGas()
        {
            InitializeComponent();
        }

        private void FormGas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                MoveBall ball = new MoveBall(rnd.Next(0, this.Width), rnd.Next(0, this.Height), this);
                ball.SetSpeed(1 + rnd.Next(5), rnd.NextDouble() * 2 * Math.PI);
                ball.Show();
            }
        }




        //private void FormGas_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        Ball ball = new Ball(e.X, e.Y, this);
        //    }
        //    else
        //    {
        //        MoveBall moveBall = new MoveBall(e.X, e.Y, this);
        //    }
        //}

    }
}
