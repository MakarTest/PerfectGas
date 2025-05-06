using PerfectGas;
using System.Windows.Forms;


namespace AeroHockey1
{
    internal class Puck:MoveBall
    {
        public Puck(int x, int y, Form form):base(x, y, form)
        {
            this.Stop();
            this.SetPicture("images/blue_puck.png");
        }
        public void Stop()
        { 
            timer.Stop();
        }
        public void Start()
        { 
            timer.Start(); 
        }
     }
}
