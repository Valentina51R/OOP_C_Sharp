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
        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Width_KeyPress(object sender, KeyPressEventArgs e)
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

            parallelepiped.Height = Utils.CheckNumber(Height.Text);
            parallelepiped.Length = Utils.CheckNumber(Lenght.Text);
            parallelepiped.Width = Utils.CheckNumber(Width.Text);

            return parallelepiped;
        }
    }
}
