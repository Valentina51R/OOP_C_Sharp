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
    public partial class AddForm : Form
    {
        // TODO: Свойство / Метод (+)
        /// <summary>
        /// Фигура.
        /// </summary>
        private FigureBase _figure;

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


        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, UserControl> _comboBoxToUserControl;

        /// <summary>
        /// 
        /// </summary>
        private readonly Dictionary<string, Func<FigureBase>> _comboBoxToAction;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControlflag;

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

            button3.Visible = false;
#if DEBUG
            button3.Visible = true;
#endif

            comboBox1.Items.AddRange(new string[]
                 { "Шар", "Пирамида", "Параллелепипед" });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Шар", addBallUserControl1},
                {"Пирамида", addPyramidUserControl1},
                {"Параллелепипед", addParallelepipedUserControl1}
            };

            // TODO: Можно создать базовый класс / интерфейс
            // с общим методом AddFigure (optional) (+)
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Действие которое выполняется когда выбрали фигуру из выпадающего списка.
            string figureType = comboBox1.SelectedItem.ToString();
            foreach (var (figure, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == figure)
                {
                    userControl.Visible = true;
                    userControlflag = userControl;
                }
            }
        }

        // TODO: Переделать в соответствии с комментариями в родительском классе
        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;

            // TODO: Перебирать textbox из нужного UserControl
            foreach (TextBox textbox in userControlflag.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show("Заполните все необходимые поля!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }

            if (flag == true)
            {

                try
                {
                    foreach (var (key, value) in _comboBoxToAction)
                    {
                        if (comboBox1.SelectedItem.ToString() == key)
                        {
                            _figureList1.Add(value.Invoke());
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Введено некорректное значение, проверьте данные!\n" +
                        "Введите одно положительное десятичное число в каждое текстовое поле.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

            // Выбор рандомной фигуры в comboBox
            comboBox1.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControlflag.Controls.OfType<TextBox>())
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
