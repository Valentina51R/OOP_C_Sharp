using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddFigureForm : Form
    {
        public AddFigureForm()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] 
            { "Шар", "Пирамида", "Параллелепипед" });
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Действие которое выполняется когда выбрали фигуру из выпадающего списка.
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

    }
}
