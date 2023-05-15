using Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ViewFigure
{
    public partial class MainForm : Form
    {
        /// <summary>
		/// Cписок фигур
		/// </summary>
		private BindingList<FigureBase> _figureList;

        private BindingList<FigureBase> _filteredList;

        /// <summary>
        /// Для файлов
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));

        /// <summary>
        /// Основная форма.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление новой фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var addFigureForm = new AddForm();

            addFigureForm.FigureAdded += (sender, figureEventArgs) =>
            {
                _figureList.Add(((FigureEventArgs)figureEventArgs).Figure);
            };
            addFigureForm.ShowDialog();
        }

        /// <summary>
        /// Удаление выбранной фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    _figureList.Remove(row.DataBoundItem as FigureBase);

                    _filteredList.Remove(row.DataBoundItem as FigureBase);
                }
            }
        }

        /// <summary>
        /// Действия при загрузки формы.
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
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<FigureBase> figures,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(figures, null);
            dataGridView.DataSource = source;
            dataGridView.Columns[0].Width = 130;
            dataGridView.Columns[1].Width = 192;
            dataGridView.Columns[2].Width = 125;
            //dataGridView.AutoSizeColumnsMode =
            //DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Очистка всего списка фигур.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanListButton_Click(object sender, EventArgs e)
        {
            _figureList.Clear();
        }

        /// <summary>
        /// Сохранение списка в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _figureList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*"
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
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка открытия фильтра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_figureList);
            newFilterForm.Show();
            newFilterForm.FigureFiltered += (sender, figureEventArgs) =>
            {
                dataGridView1.DataSource = ((FigureListEventArgs)figureEventArgs).FigureList;
                _filteredList = ((FigureListEventArgs)figureEventArgs).FigureList;
            };
        }

        /// <summary>
        /// Сброс фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanFilterButton_Click(object sender, EventArgs e)
        {
            CreateTable(_figureList, dataGridView1);
        }
    }
}