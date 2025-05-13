using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroHockey1
{
    public enum User
    {
        Left, Right
    }
    public class EngineGame
    {
        int LeftUserScore = 0;
        int RightUserScore = 0;
        Puck puck;
        Stick userLeft, userRight;
        Form form;

        public EngineGame(Form form)
        { 
            this.form = form;
            puck = new Puck(form.Width / 2, form.Height / 2, form, this);

            //userLeft = new Stick(70, form.Height / 2, form, "images/red_stick.png");
            userRight = new Stick(form.Width - 70, form.Height / 2, form, "images/blue_stick.png");
            //puck.SetObjectCollision(userLeft);
            puck.SetObjectCollision(userRight);
        }
        public void Start()
        {
            puck.SetPoint(form.Width / 2, form.Height / 2);
            puck.SetSpeed(0, 0);
            puck.Start();

            //userLeft.SetPoint(70, form.Height / 2);
            userRight.SetPoint(form.Width - 70, form.Height / 2);
        }

        public void Move(User user, Direction direction)
        {
            if (user == User.Left)
            { 
                userLeft.Move(direction);
            }

            if (user == User.Right) 
            {
                userRight.Move(direction);
            }
        }

        public void IncreaseLeftUserScore()
        { LeftUserScore += 1; }
        public void IncreaseRightUserScore() 
        { RightUserScore += 1; }

        public int GetLeftUserScore()
        { 
            return LeftUserScore;
        }

        public int GetRightUserScore()
        {
            return RightUserScore;
        }
    }
}
