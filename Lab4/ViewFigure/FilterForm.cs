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

        //TODO:
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
            VolumeTextBox.Enabled = false;
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
                if (VolumeTextBox.Text != "")
                {
                    volume = Utils.CheckNumber(VolumeTextBox.Text);
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
            if(VolumeCheckBox.Checked)
            {
                VolumeTextBox.Enabled = true;
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
            //TODO: rename(+)
            if (BallCheckBox.Checked == false &&
                PyramidCheckBox.Checked == false &&
                ParallelepipedCheckBox.Checked == false &&
                VolumeCheckBox.Checked == false)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (FigureBase figure in _listFigure)
            {
 
                switch (figure)
                {
                    case Ball when BallCheckBox.Checked:
                    case Pyramid when PyramidCheckBox.Checked:
                    case Parallelepiped when ParallelepipedCheckBox.Checked:
                        {
                            if (VolumeCheckBox.Checked )
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

                if (!BallCheckBox.Checked && !PyramidCheckBox.Checked && !ParallelepipedCheckBox.Checked)
                {
                    if (VolumeCheckBox.Checked && figure.Volume == volume)
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
