using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoeA2
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Hide();
                    Home f1 = new Home();
                    f1.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean statusTrueFalse;

        private void btnTesting1_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusTrueFalse == false)
                {
                    btnTesting1.Text = "X";
                    statusTrueFalse = true;
                }
                else
                {
                    btnTesting1.Text = "O";
                    statusTrueFalse = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTesting2_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusTrueFalse == false)
                {
                    btnTesting2.Text = "X";
                    statusTrueFalse = true;
                }
                else
                {
                    btnTesting2.Text = "O";
                    statusTrueFalse = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting3_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusTrueFalse == false)
                {
                    btnTesting3.Text = "X";
                    statusTrueFalse = true;
                }
                else
                {
                    btnTesting3.Text = "O";
                    statusTrueFalse = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting4_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusTrueFalse == false)
                {
                    btnTesting4.Text = "X";
                    statusTrueFalse = true;
                }
                else
                {
                    btnTesting4.Text = "O";
                    statusTrueFalse = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
