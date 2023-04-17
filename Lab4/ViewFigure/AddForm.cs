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
        // TODO: Свойство / Метод
        /// <summary>
        /// 
        /// </summary>
        public FigureBase figure;

        /// <summary>
        /// 
        /// </summary>
        private readonly Dictionary<string, UserControl> _comboBoxToUserControl;

        /// <summary>
        /// 
        /// </summary>
        private readonly Dictionary<string, Func<FigureBase>> _comboBoxToAction;

        public AddForm()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[]
                 { "Шар", "Пирамида", "Параллелепипед" });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Шар", addBallUserControl1},
                {"Пирамида", addPyramidUserControl1},
                {"Параллелепипед", addParallelepipedUserControl1}
            };

            // TODO: Можно создать базовый класс / интерфейс
            // с общим методом AddFigure (optional)
            _comboBoxToAction = new Dictionary<string, Func<FigureBase>>()
            {
                {"Шар", addBallUserControl1.AddBall},
                {"Пирамида", addPyramidUserControl1.AddPyramid},
                {"Параллелепипед", addParallelepipedUserControl1.AddParallelepiped}
            };
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // Все поля недоступны


            label11.ForeColor = Color.Red;

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
            foreach (TextBox textbox in Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    label11.Text = "Заполните все необходимые поля!";
                    flag = false;
                }
            }

            if (flag == true)
            {
                label11.Text = "";
                
                foreach (var motionType in _comboBoxToAction)
                {
                    if (comboBox1.SelectedItem.ToString() == motionType.Key)
                    {
                        Form1._figureList.Add(motionType.Value.Invoke());
                    }
                }
                DialogResult = DialogResult.OK;

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

            foreach (TextBox textbox in Controls.OfType<TextBox>())
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
