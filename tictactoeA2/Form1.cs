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

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MessageBoxQuestion = MessageBox.Show("Are you sure you want to continue?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (MessageBoxQuestion == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (MessageBoxQuestion == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}