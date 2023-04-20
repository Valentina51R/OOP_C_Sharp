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
    //TODO: XML(+)
    /// <summary>
    /// Форма добавления новой фигуры.
    /// </summary>
    public partial class AddForm : Form
    {
        // TODO:(+) Свойство / Метод 
        /// <summary>
        /// Фигура.
        /// </summary>
        private FigureBase _figure;

        //TODO: not using
        /// <summary>
        /// Задание фигуры.
        /// </summary>
        public FigureBase Figure 
        {
            get
            {
                return _figure;
            } 
            set
            {
                _figure = value;
            }
        }

        public EventHandler<EventArgs> FigureAdded;

        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        /// <summary>
        /// Словарь действий.
        /// </summary>
        private readonly Dictionary<string, Func<FigureBase>>
            _comboBoxToAction;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        /// <summary>
        /// Список фигур.
        /// </summary>
        private BindingList<FigureBase> _figureList1;


        /// <summary>
        /// Форма добавления фигур.
        /// </summary>
        /// <param name="_figureList"></param>
        public AddForm(BindingList<FigureBase> _figureList)
        {
            InitializeComponent();

            _figureList1 = _figureList;

            comboBoxFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            OK.Enabled = false;
#if !DEBUG
            button3.Visible = false;
#endif
            //TODO: extract string array(+)
            string[] typeFigure = { "Шар", "Пирамида", "Параллелепипед" };

            comboBoxFigures.Items.AddRange(new string[]
                 { typeFigure[0], typeFigure[1], typeFigure[2] });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeFigure[0], addBallUserControl1},
                {typeFigure[1], addPyramidUserControl1},
                {typeFigure[2], addParallelepipedUserControl1}
            };

            // TODO: (+) Можно создать базовый класс / интерфейс
            // с общим методом AddFigure (optional) 
            // Остался вопрос с применением, как не использовать этот словарь,
            // а ограничиться _comboBoxToUserControl
            //_comboBoxToAction = new Dictionary<string, Func<FigureBase>>()
            //{
            //    {typeFigure[0], addBallUserControl1.AddFigure},
            //    {typeFigure[1], addPyramidUserControl1.AddFigure},
            //    {typeFigure[2], addParallelepipedUserControl1.AddFigure}
            //};

        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            OK.Focus();
            addBallUserControl1.Visible = false;
            addParallelepipedUserControl1.Visible = false;
            addPyramidUserControl1.Visible = false;
        }

        /// <summary>
        /// Выпадающий список.
        /// Действие которое выполняется когда
        /// выбрали фигуру из выпадающего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFigeres_SelectedIndexChanged(object sender, EventArgs e)
        {

            string figureType = comboBoxFigures.SelectedItem.ToString();
            foreach (var (figure, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == figure)
                {
                    userControl.Visible = true;
                    OK.Enabled = true;
                    this.userControl = userControl;
                }
            }
        }

        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var currentFigureControlName = comboBoxFigures.SelectedItem.ToString();
                var currentFigureControl = _comboBoxToUserControl[currentFigureControlName];
                var eventArgs = new FigureEventArgs(((IAddFigure)currentFigureControl).AddFigure());
                FigureAdded?.Invoke(this, eventArgs);

                //_figureList1.Add(((IAddFigure)currentFigureControl).AddFigure());
                //DialogResult = DialogResult.OK;
                
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n" +
                    "Введите одно положительное десятичное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            comboBoxFigures.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Focus();
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }
    }
}
