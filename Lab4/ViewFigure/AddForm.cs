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
    //TODO: XML
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

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            button1.Enabled = false;
#if !DEBUG
            button3.Visible = false;
#endif
            //TODO: extract string array
            comboBox1.Items.AddRange(new string[]
                 { "Шар", "Пирамида", "Параллелепипед" });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Шар", addBallUserControl1},
                {"Пирамида", addPyramidUserControl1},
                {"Параллелепипед", addParallelepipedUserControl1}
            };

            // TODO: (+) Можно создать базовый класс / интерфейс
            // с общим методом AddFigure (optional) 
            // Остался вопрос с применением, как не использовать этот словарь,
            // а ограничиться _comboBoxToUserControl
            _comboBoxToAction = new Dictionary<string, Func<FigureBase>>()
            {
                {"Шар", addBallUserControl1.AddFigure},
                {"Пирамида", addPyramidUserControl1.AddFigure},
                {"Параллелепипед", addParallelepipedUserControl1.AddFigure}
            };

        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            button1.Focus();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string figureType = comboBox1.SelectedItem.ToString();
            foreach (var (figure, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == figure)
                {
                    userControl.Visible = true;
                    button1.Enabled = true;
                    this.userControl = userControl;
                }
            }
        }

        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var currentFigureControlName = comboBox1.SelectedItem.ToString();
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
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            comboBox1.SelectedIndex = random.Next(0, 3);

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
