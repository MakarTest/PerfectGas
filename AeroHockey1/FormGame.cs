using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectGas;

namespace AeroHockey1
{
    public partial class FormGame : Form
    {
        Puck puck;
        Stick userLeft, userRight;

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            // левый игрок
            if (e.KeyCode == Keys.W)
                { userLeft.Move(Direction.Up); }
            if (e.KeyCode == Keys.A)
                { userLeft.Move(Direction.Left); }
            if (e.KeyCode == Keys.D)
                { userLeft.Move(Direction.Right); }
            if (e.KeyCode == Keys.S)
                { userLeft.Move(Direction.Down); } 

            // правый игрок
            if (e.KeyCode == Keys.Up)
                { userRight.Move(Direction.Up); }
            if (e.KeyCode == Keys.Left)
                { userRight.Move(Direction.Left); }
            if (e.KeyCode == Keys.Right)
                { userRight.Move(Direction.Right); }
            if (e.KeyCode == Keys.Down)
                { userRight.Move(Direction.Down); }
        }

        public FormGame()
        {
            InitializeComponent();
            puck = new Puck(this.Width / 2, this.Height / 2, this);
            
            userLeft = new Stick(70, this.Height / 2, this, "images/red_stick.png");
            userRight = new Stick(this.Width - 70, this.Height / 2, this, "images/blue_stick.png");
            //puck.SetObjectCollision(userLeft);
            puck.SetSpeed(0, 0);
            puck.Start();
            puck.SetObjectCollision(userRight);
            //puck.Start();
        }
    }
}
