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
    /// <summary>
    /// Добавление новой пирамиды.
    /// </summary>
    public partial class AddPyramidUserControl : UserControl, IAddFigure
    {
        /// <summary>
        /// Добавление пирамиды.
        /// </summary>
        public AddPyramidUserControl()
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
        /// Метод создания пирамиды.
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var pyramid = new Pyramid();

            pyramid.Height = Utils.CheckNumber(textBox1.Text);
            pyramid.Square = Utils.CheckNumber(textBox2.Text);

            return pyramid;
        }
    }
}
