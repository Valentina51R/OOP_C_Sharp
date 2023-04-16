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
    public partial class AddPyramidUserControl : UserControl
    {

        public AddPyramidUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddForm.CheckInput(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddForm.CheckInput(e);
        }

        public FigureBase AddPyramid()
        {
            var pyramid = new Pyramid();

            var actions = new List<Action>()
            {
                () =>
                {
                    pyramid.Height = AddForm.CheckNumber(textBox1.Text);
                },
                () =>
                {
                    pyramid.Square = AddForm.CheckNumber(textBox2.Text);
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
