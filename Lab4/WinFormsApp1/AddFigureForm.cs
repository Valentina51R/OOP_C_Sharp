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
            string figureType = comboBox1.SelectedItem.ToString();
            switch(figureType)
            {
                case "Шар":
                    {
                        // Давать доступ к соответсвующим полям
                        MessageBox.Show(figureType);
                        break;
                    }
                case "Пирамида":
                    {
                        // Давать доступ к соответсвующим полям
                        MessageBox.Show(figureType);
                        break;
                    }
                case "Параллелепипед":
                    {
                        // Давать доступ к соответсвующим полям
                        MessageBox.Show(figureType);
                        break;
                    }
                    default:
                    break;
            }
            
        }

    }
}
