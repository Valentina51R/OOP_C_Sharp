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
    public partial class AddParallelepipedUserControl : UserControl
    {

        public AddParallelepipedUserControl()
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddForm.CheckInput(e);
        }


        public FigureBase AddParallelepiped()
        {
            var parallelepiped = new Parallelepiped();

            var actions = new List<Action>()
            {
                () =>
                {
                    parallelepiped.Height = AddForm.CheckNumber(textBox1.Text);
                },
                () =>
                {
                    parallelepiped.Length = AddForm.CheckNumber(textBox2.Text);
                },
                () =>
                {
                    parallelepiped.Width = AddForm.CheckNumber(textBox3.Text);
                }
            };

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return parallelepiped;
        }
    }
}
