using Model;
using System.Windows.Forms;
using View;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // экземпляр (объект) класса формы Form2
        private AddFigureForm? _addFigure;

        public List<FigureBase> figureList;

        public Form1()
        {
            InitializeComponent();

            //string[] figures = { "Элемент списка 1", "Элемент списка 2"};
            //listBox1.Items.AddRange(figures);

            //FigureBase ball = new Ball(8);
            //FigureBase parallelepiped = new Parallelepiped(8.6d, 7, 9);
            //FigureBase pyramid = new Pyramid(8, 7);

            //listBox1.Items.Add(ball.GetInfo());
            //listBox1.Items.Add(parallelepiped.GetInfo());
            //listBox1.Items.Add(pyramid.GetInfo());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Добавление новой фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            _addFigure.ShowDialog();
        }

        /// <summary>
        /// Удаление выбранной фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
            listBox1.Items.RemoveAt(index);
            //figureList.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Выделение памяти для формы AddFigure
            _addFigure = new AddFigureForm(dataGridView1, listBox1, figureList);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}