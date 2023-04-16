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
            //ball = (Ball)figure;
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox1.Text != "")
            //    {
            //        ball.Radius = AddForm.CheckNumber(textBox1.Text);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddForm.CheckInput(e);
        }


        public FigureBase AddBall()
        {
            var ball = new Ball();

            var actions = new List<Action>()
            {
                () =>
                {
                    ball.Radius = AddForm.CheckNumber(textBox1.Text);
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
