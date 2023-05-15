using Model;
using System;
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
        /// Обработчик события.
        /// </summary>
        public EventHandler<EventArgs> FigureFiltered;

        /// <summary>
        /// Объём.
        /// </summary>
        private double volume;

        /// <summary>
        /// Форма фильтрации.
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="dataGrid"></param>
        public FilterForm(BindingList<FigureBase> figures)
        {
            InitializeComponent();
            _listFigure = figures;
            VolumeTextBox.Enabled = false;
        }

        /// <summary>
        /// Ввод объёма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVolume_TextChanged(object sender, EventArgs e)
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
        private void textBoxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Флажок активации поля ввода объёма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxVolume_CheckedChanged(object sender, EventArgs e)
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
            if (!BallCheckBox.Checked 
                && !PyramidCheckBox.Checked 
                && !ParallelepipedCheckBox.Checked 
                && !VolumeCheckBox.Checked)
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

                if (!BallCheckBox.Checked 
                    && !PyramidCheckBox.Checked 
                    && !ParallelepipedCheckBox.Checked)
                {
                    if (VolumeCheckBox.Checked && figure.Volume == volume)
                    {
                        count++;
                        _listFigureFilter.Add(figure);
                    }
                }     
            }

            FigureListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new FigureListEventArgs(_listFigureFilter);
            }
            else
            {
                MessageBox.Show("Нет фигур удовлетворяющих фильтру!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eventArgs = new FigureListEventArgs(_listFigureFilter);
                return;
            }

            FigureFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}
