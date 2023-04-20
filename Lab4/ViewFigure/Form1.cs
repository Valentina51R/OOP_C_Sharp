using Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ViewFigure
{
    //TODO: rename
    public partial class Form1 : Form
    {
        //TODO: static?
        /// <summary>
		/// C����� �����
		/// </summary>
		private static BindingList<FigureBase> _figureList;

        /// <summary>
        /// ��� ������
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));

        /// <summary>
        /// �������� �����.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        //TODO: rename
        /// <summary>
        /// ���������� ����� ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            //TODO: remake
            var addFigureForm = new AddForm(_figureList);
            addFigureForm.FigureAdded += (sender, figureEventArgs) =>
            {
                _figureList.Add(((FigureEventArgs)figureEventArgs).Figure);
            };
            if (addFigureForm.ShowDialog() == DialogResult.OK)
            {
                _figureList.Add(addFigureForm.Figure);
            }
        }

        //TODO: rename
        /// <summary>
        /// �������� ��������� ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    _figureList.RemoveAt(row.Index);
                }
            }
        }

        /// <summary>
        /// �������� ��� �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������
            _figureList = new BindingList<FigureBase>();
            CreateTable(_figureList, dataGridView1);
        }

        /// <summary>
        /// �������� ������� DataGrid.
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<FigureBase> figures,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            //TODO: binding source
            var source = new BindingSource(_figureList, null);
            dataGridView.DataSource = source;
            //dataGridView.Columns[0].HeaderText = "������";
            //dataGridView.Columns[1].HeaderText = "���������";
            //dataGridView.Columns[2].HeaderText = "�����, �";
            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        //TODO: rename
        /// <summary>
        /// ������� ����� ������ �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            _figureList.Clear();
        }

        /// <summary>
        /// ���������� ������ � ����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_figureList.Count == 0)
            {
                MessageBox.Show("����������� ������ ��� ����������.",
                    "������ �� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "����� (*.fgr)|*.fgr|��� ����� (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _figureList);
                }
                MessageBox.Show("���� ������� �������.",
                    "���������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.fgr)|*.fgr|��� ����� (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _figureList = (BindingList<FigureBase>)
                        _serializer.Deserialize(file);
                }

                dataGridView1.DataSource = _figureList;
                dataGridView1.CurrentCell = null;
                MessageBox.Show("���� ������� ��������.",
                    "�������� ���������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("�� ������� ��������� ����.\n" +
                    "���� �������� ��� �� ������������� �������.",
                    "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: rename
        /// <summary>
        /// ������ �������� �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_figureList, dataGridView1);
            newFilterForm.Show();
        }

        //TODO: rename
        /// <summary>
        /// ����� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            CreateTable(_figureList, dataGridView1);
        }
    }
}