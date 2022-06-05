namespace tictactoeA2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();
            Play f2 = new Play();
            f2.Show(); 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}