using Model;
using System.Windows.Forms;
using View;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // ��������� (������) ������ ����� Form2
        private AddFigureForm? _addFigure;

        public Form1()
        {
            InitializeComponent();

            string[] figures = { "������� ������ 1", "������� ������ 2"};
            listBox1.Items.AddRange(figures);

            FigureBase ball = new Ball(8);
            FigureBase parallelepiped = new Parallelepiped(8.6d, 7, 9);
            FigureBase pyramid = new Pyramid(8, 7);

            listBox1.Items.Add(ball.GetInfo());
            listBox1.Items.Add(parallelepiped.GetInfo());
            listBox1.Items.Add(pyramid.GetInfo());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //_ = MessageBox.Show("��� ����� ����� ���������� �����.");

            _addFigure.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("��� ������ ��� �������� ������.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // ��������� ������ ��� ����� AddFigure
            _addFigure = new AddFigureForm();

        }


    }
}