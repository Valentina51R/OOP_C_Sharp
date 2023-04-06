using Model;
using System.Windows.Forms;
using View;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // экземпляр (объект) класса формы Form2
        private AddFigureForm? _addFigure;

        public Form1()
        {
            InitializeComponent();

            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            listBox1.Items.AddRange(countries);

            FigureBase ball = new Ball(85);

            listBox1.Items.Add(ball.GetInfo());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //_ = MessageBox.Show("Тут будет форма заполнения фигур.");

            _addFigure.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Эта кнопка для удаления фигуры.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Выделение памяти для формы AddFigure
            _addFigure = new AddFigureForm();

        }


    }
}