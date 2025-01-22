namespace AADCollector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Audio-Acceleration Data Collector";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
