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
        /// Объём.
        /// </summary>
        private double volume;

        /// <summary>
        /// Добавление шара.
        /// </summary>
        public AddBallUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод изменении содержимого текстового поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Метод добавления фигуры.
        /// </summary>
        /// <returns></returns>
        public FigureBase AddFigure()
        {
            var ball = new Ball();

            ball.Radius = volume;

            //var actions = new List<Action>()
            //{
            //    () =>
            //    {
            //        ball.Radius = volume;
            //    }
            //};

            //foreach (var action in actions)
            //{
            //    action.Invoke();
            //}

            return ball;
        }
    }
}
