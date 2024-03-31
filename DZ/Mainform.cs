using System.Windows.Forms;


namespace DZ
{
    public partial class Mainform : Form
    {
        private System.Windows.Forms.Timer timer1;
        public Mainform()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; 
            timer1.Start();
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
        


        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

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
                var chel = context.Guests.Where(c => c.Status == "Заняты").ToList();
                dataGridView1.DataSource = chel;
            }
        }

        private void time_Click(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
