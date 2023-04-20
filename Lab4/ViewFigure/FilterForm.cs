using Model;
using System.ComponentModel;

namespace ViewFigure
{
    /// <summary>
    /// Форма фильтрации.
    /// </summary>
    public partial class FilterForm : Form
    {

        /// <summary>
        /// Лист фильтруемых фигур
        /// </summary>
        private readonly BindingList<FigureBase> _listFigure;

        /// <summary>
        /// Лист отфильтрованных фигур
        /// </summary>
        private BindingList<FigureBase> _listFigureFilter;

        /// <summary>
        /// DataGrid.
        /// </summary>
        private DataGridView dataGridview;

        /// <summary>
        /// Объём.
        /// </summary>
        private double volume;

        /// <summary>
        /// Форма фильтрации.
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="dataGrid"></param>
        public FilterForm(BindingList<FigureBase> figures, DataGridView dataGrid)
        {
            InitializeComponent();
            _listFigure = figures;
            dataGridview = dataGrid;
            textBox1.Enabled = false;
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
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Флажок активации поля ввода объёма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            _listFigureFilter = new BindingList<FigureBase>();

            int count = 0;
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (FigureBase figure in _listFigure)
            {
 
                switch (figure)
                {
                    case Ball when checkBox1.Checked:
                    case Pyramid when checkBox2.Checked:
                    case Parallelepiped when checkBox3.Checked:
                        {
                            if (checkBox4.Checked )
                            {
                                if (figure.Volume == volume)
                                {
                                    count++;
                                    _listFigureFilter.Add(figure);
                                    break;
                                }
                                break;
                            }
                            else
                            {
                                count++;
                                _listFigureFilter.Add(figure);
                                break;
                            }
                        }
                }

                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                {
                    if (checkBox4.Checked && figure.Volume == volume)
                    {
                        count++;
                        _listFigureFilter.Add(figure);
                    }
                }     
            }

            if (count > 0)
            {
                dataGridview.DataSource = _listFigureFilter;
                Close();
            }
            else
            {
                MessageBox.Show("Нет фигур удовлетворяющих фильтру!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dataGridview.DataSource = _listFigureFilter;
                Close();
                return;
            }
        }
    }
}
