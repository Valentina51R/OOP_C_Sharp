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
    /// Добавление нового шара.
    /// </summary>
    public partial class AddBallUserControl : UserControl, IAddFigure
    {

        /// <summary>
        /// Добавление шара.
        /// </summary>
        public AddBallUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Radius_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления фигуры.
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var ball = new Ball();

            ball.Radius = Utils.CheckNumber(Radius.Text);

            return ball;
        }

    }
}
