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
    public partial class AddBallUserControl : UserControl, IAddFigure
    {

        private double volume;

        public AddBallUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    volume = Utils.CheckNumber(textBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число больше нуля!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }


        public FigureBase AddFigure()
        {
            var ball = new Ball();

            var actions = new List<Action>()
            {
                () =>
                {
                    ball.Radius = volume;
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
