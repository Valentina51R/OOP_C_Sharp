using Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ViewFigure
{
    public partial class Form1 : Form
    {
        /// <summary>
		/// Cписок фигур
		/// </summary>
		private static BindingList<FigureBase> _figureList;

        /// <summary>
        /// Для файлов
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));

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
            var addFigureForm = new AddForm(_figureList);
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
            dataGridView.Columns[0].HeaderText = "Фигура";
            dataGridView.Columns[1].HeaderText = "Параметры";
            dataGridView.Columns[2].HeaderText = "Объём, м";
            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Очистка всего списка фтгур.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            _figureList.Clear();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_figureList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*",
                AddExtension = true,
                DefaultExt = ".fgr"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream fileStream = new FileStream(path,
                    FileMode.OpenOrCreate))
                {
                    _serializer.Serialize(fileStream, _figureList);
                }
                MessageBox.Show("Файл успешно сохранён.", "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*",
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (FileStream fileStream = new FileStream(path,
                    FileMode.OpenOrCreate))
                {
                    _figureList = (BindingList<FigureBase>)_serializer.Deserialize(fileStream);
                }
                dataGridView1.DataSource = _figureList;
                dataGridView1.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.", "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка открытия фильтра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_figureList, dataGridView1);
            newFilterForm.Show();
        }

        /// <summary>
        /// Сброс фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            CreateTable(_figureList, dataGridView1);
        }
    }
}