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
        public FormGame()
        {
            InitializeComponent();
            puck = new Puck(this.Width / 2, this.Height / 2, this);
            userLeft = new Stick(70, this.Height / 2, this);
            userRight = new Stick(this.Width - 70, this.Height / 2, this);
        }
    }
}
