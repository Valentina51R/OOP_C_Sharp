using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace ViewFigure
{
    public partial class AddBallUserControl : UserControl
    {
       
        //public Ball ball;

        public AddBallUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }


        public FigureBase AddBall()
        {
            var ball = new Ball();

            var actions = new List<Action>()
            {
                () =>
                {
                    ball.Radius = Utils.CheckNumber(textBox1.Text);
                }
            };

            foreach (var action in actions)
            {
              action.Invoke();    
            }

            return ball;
        }

    }
}
