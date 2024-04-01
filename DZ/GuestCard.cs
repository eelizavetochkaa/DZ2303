using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DZ
{
    public partial class GuestCard : Form
    {
        private string data;

        public GuestCard()
        {
            InitializeComponent();
            quantity.ValueChanged += quantity_ValueChanged;
        }
        public void SetData(string data1, string data2)
        {
            FIO2.Text = data1;
            Birth.Text = data2;
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            int counterValue = (int)quantity.Value;
            int sum = 7490 * counterValue;
            summ.Text = sum.ToString();
        }

        private void write_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }
        private void SaveDataToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string data1 = FIO2.Text;
                string data2 = Birth.Text;
                string data3 = summ.Text;
                string checkBoxData = animals.Checked ? "Путешествует с животным(и)" : "";
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(data1);
                    writer.WriteLine(data2);
                    writer.WriteLine(data3);
                    if (!string.IsNullOrEmpty(checkBoxData))
                    {
                        writer.WriteLine(checkBoxData);
                    }
                }

                MessageBox.Show("Информация сохранена в файл: " + saveFileDialog.FileName);
            }
        }
    }
}
