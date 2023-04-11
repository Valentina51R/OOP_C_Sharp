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
using WinFormsApp1;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace View
{
    public partial class AddFigureForm : Form
    {

        // экземпляр (объект) класса формы Form2
        private Form1? _form1;

        private FigureBase figure = new Ball();

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private List<FigureBase> figureList1;

        public AddFigureForm(DataGridView dataGridView, ListBox listBox, List<FigureBase> figureList)
        {
            dataGridView1 = dataGridView;
            listBox1 = listBox;
            figureList1 = figureList;
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] 
            { "Шар", "Пирамида", "Параллелепипед" });

            label11.ForeColor = Color.Red;

        }


        /// <summary>
        /// Кнопка "Ок".
        /// </summary>
        /// <param name="sender"> а.</param>
        /// <param name="e">и.</param>
        public void Button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (TextBox textbox in Controls.OfType<TextBox>())
            {
                if (textbox.Enabled && String.IsNullOrEmpty(textbox.Text))
                {
                    label11.Text = "Заполните все необходимые поля!";
                    flag = false;
                }
            }

            if (flag == true)
            {
                label11.Text = "";
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Кнопка "Cancel".
        /// Отмена добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button2_Click(object sender, EventArgs e)
        {
            // TODO: отменить добавление фигуры.
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Добавление ячейки в dataGrid.
        /// </summary>
        /// <param name="figureInfo"></param>
        public void AddRecord(string figureInfo)
        {
            // Настройка DaraGrid
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.Both;

            dataGridView1.ColumnCount = 1;
            dataGridView1.Rows.Add(figureInfo);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 250;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30;
            }

        }

        /// <summary>
        /// Выбор из выпадающего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Действие которое выполняется когда выбрали фигуру из выпадающего списка.
            string figureType = comboBox1.SelectedItem.ToString();
            switch(figureType)
            {
                case "Шар":
                    {
                        // Давать доступ к соответсвующим полям
                        textBox1.Enabled = true;
                        figure = new Ball();
                        break;
                    }
                case "Пирамида":
                    {
                        // Давать доступ к соответсвующим полям
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        figure = new Pyramid();
                        break;
                    }
                case "Параллелепипед":
                    {
                        // Давать доступ к соответсвующим полям
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        figure = new Parallelepiped();
                        break;
                    }
                    default:
                    break;
            }
            
        }

        private void AddFigureForm_Load(object sender, EventArgs e)
        {
            // Все поля недоступны
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            // Выделение памяти для формы Form2
            _form1 = new Form1();

        }

        private void AddFigureForm_Closed(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            //TODO: удалить надпись из comboBox
            //comboBox1.SelectedIndex = -1;
            //comboBox1.ResetText();

            // Добавление фигуры в listBox1 и dataGridView1
            listBox1.Items.Add(figure.GetInfo());
            AddRecord(figure.GetInfo());

            // Добавление в список
            //figureList1.Add(figure);
        }

        /// <summary>
        /// Метод проверки введеных символов
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }
            return double.Parse(number);
        }


        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Ball ball1 = (Ball)figure;
                ball1.Radius = CheckNumber(textBox1.Text);
            }

        }
        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Pyramid pyramid1 = (Pyramid)figure;
                pyramid1.Height = CheckNumber(textBox2.Text);
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Pyramid pyramid1 = (Pyramid)figure;
                pyramid1.Square = CheckNumber(textBox3.Text);
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != null)
            {
                Parallelepiped parallelepiped1 = (Parallelepiped)figure;
                parallelepiped1.Height = CheckNumber(textBox4.Text);
            }
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
            {
                Parallelepiped parallelepiped1 = (Parallelepiped)figure;
                parallelepiped1.Width = CheckNumber(textBox5.Text);
            }

        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
            {
                Parallelepiped parallelepiped1 = (Parallelepiped)figure;
                parallelepiped1.Length = CheckNumber(textBox6.Text);
            }

        }


        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        /// <summary>
        /// Метод позволяющий вводить только
        /// числа и запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e"></param>
        private static void CheckInput(KeyPressEventArgs e)
        {
            //цифры, клавиша BackSpace и запятая а ASCII
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }
        }

    }
}
