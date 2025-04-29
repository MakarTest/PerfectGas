using PerfectGas;

namespace AeroHockey
{
    public partial class FormGame : Form
    {
        Puck puck;

        public FormGame()
        {
            InitializeComponent();
            Ball ball = new Ball(100, 100, this);
            //puck = new Puck(this.Width / 2, this.Height / 2, this);
            //puck.Equals(this);
        }
    }
}