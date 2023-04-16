using Model;
using System.ComponentModel;
using System.Windows.Forms;
using View;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        // ��������� (������) ������ ����� Form2
        private AddFigureForm? _addFigure;

        /// <summary>
		/// C����� �����
		/// </summary>
		public static BindingList<FigureBase> _figureList =
            new BindingList<FigureBase>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// ���������� ����� ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            _addFigure.ShowDialog();
        }

        /// <summary>
        /// �������� ��������� ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
            //figureList.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������ ��� ����� AddFigure
            CreateTable(_figureList, dataGridView1);
            _addFigure = new AddFigureForm(dataGridView1, _figureList);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        public static void CreateTable(BindingList<FigureBase> figures,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = figures;
            dataGridView.Columns[0].HeaderText = "������";
            //dataGridView.Columns[1].HeaderText = "���������";
            //dataGridView.Columns[2].HeaderText = "����� (�)";
            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}