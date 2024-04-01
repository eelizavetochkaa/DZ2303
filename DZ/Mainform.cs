using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace DZ
{
    public partial class Mainform : Form
    {
        public string GetSelectedData(int columnIndex)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                return dataGridView1.Rows[selectedRowIndex].Cells[columnIndex].Value?.ToString();
            }
            return string.Empty;
        }
        

        private System.Windows.Forms.Timer timer1;
        public Mainform()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;
            time.Text = currentTime.ToString("HH:mm:ss");
        }

        private void Reserved_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new BdContext())
            {
                var chel = context.Guests.Where(c => c.Status == "Зарезервировано").ToList();
                dataGridView1.DataSource = chel;
            }
        }

        private void Free_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new BdContext())
            {
                var chel = context.Guests.Where(c => c.Status == "Свободные").ToList();
                dataGridView1.DataSource = chel;
            }
        }

        private void Busy_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new BdContext())
            {
                var chel = context.Guests.Where(c => c.Status == "Заняты").ToList();
                dataGridView1.DataSource = chel;
            }
        }

        private void CheckingOut_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new BdContext())
            {
                var chel = context.Guests.Where(c => c.Status == "Выписываются").ToList();
                dataGridView1.DataSource = chel;
            }
        }

        private void time_Click(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GuestCard guestcard = new GuestCard();

            string data1 = GetSelectedData(1);
            string data2 = GetSelectedData(2);

            guestcard.SetData(data1, data2);

            guestcard.Show();

            this.Hide();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Проверяем, что была затронутая ячейка
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int columnIndex1 = 1;
                int columnIndex3 = 3;
                int columnIndex5 = 5;
                int columnIndex6 = 6;
                int columnIndex7 = 7;


                string columnValue1 = dataGridView1.Rows[e.RowIndex].Cells[columnIndex1].Value.ToString();
                string columnValue3 = dataGridView1.Rows[e.RowIndex].Cells[columnIndex3].Value.ToString();
                string columnValue5 = dataGridView1.Rows[e.RowIndex].Cells[columnIndex5].Value.ToString();
                string columnValue6 = dataGridView1.Rows[e.RowIndex].Cells[columnIndex6].Value.ToString();
                string columnValue7 = dataGridView1.Rows[e.RowIndex].Cells[columnIndex7].Value.ToString();

                FIO.Text = columnValue1;
                status2.Text = columnValue3;
                dateofarrival2.Text = columnValue5;
                dateofdeparture2.Text = columnValue6;
                number.Text = columnValue7;
            }
        }
    }
}
