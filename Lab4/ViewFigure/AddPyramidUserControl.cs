using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewFigure
{
    public partial class AddPyramidUserControl : UserControl, IAddFigure
    {

        public AddPyramidUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        public FigureBase AddFigure()
        {
            var pyramid = new Pyramid();

            var actions = new List<Action>()
            {
                () =>
                {
                    pyramid.Height = Utils.CheckNumber(textBox1.Text);
                },
                () =>
                {
                    pyramid.Square = Utils.CheckNumber(textBox2.Text);
                }
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }
            return pyramid;
        }
    }
}
