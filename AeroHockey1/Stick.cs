using PerfectGas;
using System.Windows.Forms;

namespace AeroHockey1
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    internal class Stick : Ball
    {
        public Stick(int x, int y, Form form, string fileName):base(x, y, form)
        { 
            this.Load(fileName);
        }

        public void Move(Direction dir)
        { 
            if (dir == Direction.Up) 
            {
                y -= 5;
            }

            if (dir == Direction.Down)
            {
                this.y += 5;
            }

            if (dir == Direction.Left)
            { 
                this.x -= 5;
            }

            if (dir == Direction.Right)
            {
                this.x += 5;
            }
            this.SetPoint((int)this.x, (int)this.y);
        }
    }
}
