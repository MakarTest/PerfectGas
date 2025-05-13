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
        EngineGame game;
       

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            // левый игрок
            if (e.KeyCode == Keys.W)
                { game.Move(User.Left, Direction.Up); }
            if (e.KeyCode == Keys.A)
            {
                game.Move(User.Left, Direction.Left);
            }

            //if (e.KeyCode == Keys.D)
            //    { userLeft.Move(Direction.Right); }
            //if (e.KeyCode == Keys.S)
            //    { userLeft.Move(Direction.Down); } 

            //// правый игрок
            //if (e.KeyCode == Keys.Up)
            //    { userRight.Move(Direction.Up); }
            if (e.KeyCode == Keys.Left)
            { 
                game.Move(User.Right, Direction.Left); 
            }
            //if (e.KeyCode == Keys.Right)
            //    { userRight.Move(Direction.Right); }
            //if (e.KeyCode == Keys.Down)
            //    { userRight.Move(Direction.Down); }
        }

        public FormGame()
        {
            InitializeComponent();
            game = new EngineGame(this);
            game.Start();
           
        }
    }
}
