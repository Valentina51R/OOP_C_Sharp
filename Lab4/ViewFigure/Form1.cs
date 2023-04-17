using Model;
using System.ComponentModel;
using System.Windows.Forms;

namespace ViewFigure
{
    public partial class Form1 : Form
    {
        /// <summary>
		/// Cписок фигур
		/// </summary>
		private static BindingList<FigureBase> _figureList;

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление новой фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            var addFigureForm = new AddForm();
            addFigureForm.ShowDialog();
            // TODO: Алгоритм
            // Вызываем новую дочернюю форму
            // В дочерней форме заполняется информация о фигуре
            // Родительская форма считывает информацию из дочерней формы, когда она закроется и статус ОК
        }

        /// <summary>
        /// Удаление выбранной фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    _figureList.Remove(row.DataBoundItem as FigureBase);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Выделение памяти
            _figureList = new BindingList<FigureBase>();
            CreateTable(_figureList, dataGridView1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<FigureBase> figures,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = figures;
            //dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].HeaderText = "Фигура";
            //dataGridView.Columns[1].HeaderText = "Параметры";
            //dataGridView.Columns[2].HeaderText = "Объём (м)";
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