using Model;
using System.ComponentModel;
using System.Windows.Forms;

namespace ViewFigure
{
    public partial class Form1 : Form
    {
        // ��������� (������) ������ ����� Form2
        private AddForm _addFigure = new AddForm();

        /// <summary>
		/// C����� �����
		/// </summary>
		public static BindingList<FigureBase> _figureList =
            new BindingList<FigureBase>();


        public Form1()
        {
            InitializeComponent();
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
            //int index = dataGridView1.CurrentRow.Index;
            //dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
            //figureList.RemoveAt(index);

            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    _figureList.Remove(cell.OwningRow.DataBoundItem as FigureBase);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������
            _addFigure = new AddForm();
            CreateTable(_figureList, dataGridView1);
        }

        public static void CreateTable(BindingList<FigureBase> figures,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = figures;
            //dataGridView.ColumnCount = 3;
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