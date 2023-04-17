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
    public partial class FilterForm : Form
    {

        /// <summary>
        /// Лист фильтрованных фигур
        /// </summary>
        private readonly BindingList<FigureBase> _listFigureFilter;

        /// <summary>
        /// Листотфильтрованных фигур
        /// </summary>
        private BindingList<FigureBase> _newlistFigureFilter;

        private DataGridView dataGridview;

        private double volume;

        public FilterForm(BindingList<FigureBase> figures, DataGridView dataGrid)
        {
            InitializeComponent();
            _listFigureFilter = figures;
            dataGridview = dataGrid;
            textBox1.Enabled = false;
        }


        /// <summary>
        /// Выбор фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ввод объёма
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                textBox1.Enabled = true;
            }
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            _newlistFigureFilter = new BindingList<FigureBase>();

            int count = 0;
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false)
            {
                MessageBox.Show("Критерии для поиска не введены!");
                return;
            }

            foreach (FigureBase figure in _listFigureFilter)
            {
                switch (figure)
                {
                    case Ball _ when checkBox1.Checked:
                    case Pyramid _ when checkBox2.Checked:
                    case Parallelepiped _ when checkBox3.Checked:
                        {
                            count++;
                            _newlistFigureFilter.Add(figure);
                            break;
                        }
                }

                if (checkBox4.Checked && 
                    (figure.Volume == volume))
                {
                    count++;
                    _newlistFigureFilter.Add(figure);
                }
            }

            if (count > 0)
            {
                dataGridview.DataSource = _newlistFigureFilter;
                Close();
            }
            else
            {
                MessageBox.Show("Нет фигур удовлетворяющих фильтру!");
                dataGridview.DataSource = _newlistFigureFilter;
                Close();
                return;
            }
            

        }

    }
}
