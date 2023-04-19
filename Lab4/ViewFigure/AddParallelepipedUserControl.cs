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
    /// <summary>
    /// Добавление нового параллелепипеда.
    /// </summary>
    public partial class AddParallelepipedUserControl : UserControl, IAddFigure
    {
        /// <summary>
        /// Добавление параллелепипеда.
        /// </summary>
        public AddParallelepipedUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления фигур.
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var parallelepiped = new Parallelepiped();

            parallelepiped.Height = Utils.CheckNumber(textBox1.Text);
            parallelepiped.Length = Utils.CheckNumber(textBox2.Text);
            parallelepiped.Width = Utils.CheckNumber(textBox3.Text);

            return parallelepiped;
        }
    }
}
