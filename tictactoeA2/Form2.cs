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
                if (btnTesting1.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting1.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting1.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
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
                if (btnTesting2.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting2.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting2.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
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
                if (btnTesting3.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting3.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting3.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
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
                if (btnTesting4.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting4.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting4.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting5_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTesting5.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting5.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting5.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting6_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTesting6.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting6.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting6.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting7_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTesting7.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting7.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting7.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting8_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTesting8.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting8.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting8.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTesting9_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTesting9.Text == "")
                {
                    if (statusTrueFalse == false)
                    {
                        btnTesting9.Text = "X";
                        statusTrueFalse = true;
                        checkStatusResult();
                    }
                    else
                    {
                        btnTesting9.Text = "O";
                        statusTrueFalse = false;
                        checkStatusResult();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnReset()
        {
            btnTesting1.Text = btnTesting.Text;
            btnTesting2.Text = btnTesting.Text;
            btnTesting3.Text = btnTesting.Text;
            btnTesting4.Text = btnTesting.Text;
            btnTesting5.Text = btnTesting.Text;
            btnTesting6.Text = btnTesting.Text;
            btnTesting7.Text = btnTesting.Text;
            btnTesting8.Text = btnTesting.Text;
            btnTesting9.Text = btnTesting.Text;
        }

        void btnOn()
        {
            btnTesting1.Enabled = true;
            btnTesting2.Enabled = true;
            btnTesting3.Enabled = true;
            btnTesting4.Enabled = true;
            btnTesting5.Enabled = true;
            btnTesting6.Enabled = true;
            btnTesting7.Enabled = true;
            btnTesting8.Enabled = true;
            btnTesting9.Enabled = true;
        }

        void btnOff()
        {
            btnTesting1.Enabled = false;
            btnTesting2.Enabled = false;
            btnTesting3.Enabled = false;
            btnTesting4.Enabled = false;
            btnTesting5.Enabled = false;
            btnTesting6.Enabled = false;
            btnTesting7.Enabled = false;
            btnTesting8.Enabled = false;
            btnTesting9.Enabled = false;
        }

        void btnBackColor()
        {
            btnTesting1.BackColor = Color.White;
            btnTesting2.BackColor = Color.White;
            btnTesting3.BackColor = Color.White;
            btnTesting4.BackColor = Color.White;
            btnTesting5.BackColor = Color.White;
            btnTesting6.BackColor = Color.White;
            btnTesting7.BackColor = Color.White;
            btnTesting8.BackColor = Color.White;
            btnTesting9.BackColor = Color.White;
        }

        void btnValue()
        {
            btnTesting1.Text = btnTesting2.Text = btnTesting3.Text = btnTesting4.Text = btnTesting5.Text =
               btnTesting6.Text = btnTesting7.Text = btnTesting8.Text = btnTesting9.Text = "";
        }

        void continueNextRound()
        {
            try
            {
                if (statusTrueFalse == true)
                {
                    statusTrueFalse = false;
                }
                btnOn();
                btnBackColor();
                btnValue();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ushort scoreCount;

        void nextmessageBoxResultX()
        {
            try
            {
                MessageBox.Show("Congratulations! Player X won the game.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreCount = ushort.Parse(lblPXScore.Text);
                lblPXScore.Text = Convert.ToString(scoreCount + 1);
                btnOff();
                continueNextRound();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void nextmessageBoxResultO()
        {
            try
            {
                MessageBox.Show("Congratulations! Player O won the game.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreCount = ushort.Parse(lblPOScore.Text);
                lblPOScore.Text = Convert.ToString(scoreCount + 1);
                btnOff();
                continueNextRound();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void nextmessageBoxResultXO()
        {
            try
            {
                MessageBox.Show("Oh no! it's draw. Please play again.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOff();
                continueNextRound();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void checkStatusResult()
        {
            //For player X
            if (btnTesting1.Text == "X" && btnTesting4.Text == "X" && btnTesting7.Text == "X")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;    
                    btnTesting4.BackColor = Color.LightGray;
                    btnTesting7.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting2.Text == "X" && btnTesting5.Text == "X" && btnTesting8.Text == "X")
            {
                try
                {
                    btnTesting2.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting8.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting3.Text == "X" && btnTesting6.Text == "X" && btnTesting9.Text == "X")
            {
                try
                {
                    btnTesting3.BackColor = Color.LightGray;
                    btnTesting6.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting1.Text == "X" && btnTesting2.Text == "X" && btnTesting3.Text == "X")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;
                    btnTesting2.BackColor = Color.LightGray;
                    btnTesting3.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting4.Text == "X" && btnTesting5.Text == "X" && btnTesting6.Text == "X")
            {
                try
                {
                    btnTesting4.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting6.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting7.Text == "X" && btnTesting8.Text == "X" && btnTesting9.Text == "X")
            {
                try
                {
                    btnTesting7.BackColor = Color.LightGray;
                    btnTesting8.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting1.Text == "X" && btnTesting5.Text == "X" && btnTesting9.Text == "X")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting7.Text == "X" && btnTesting5.Text == "X" && btnTesting3.Text == "X")
            {
                try
                {
                    btnTesting7.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting3.BackColor = Color.LightGray;
                    nextmessageBoxResultX();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //For player O
            else if (btnTesting1.Text == "O" && btnTesting4.Text == "O" && btnTesting7.Text == "O")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;
                    btnTesting4.BackColor = Color.LightGray;
                    btnTesting7.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting2.Text == "O" && btnTesting5.Text == "O" && btnTesting8.Text == "O")
            {
                try
                {
                    btnTesting2.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting8.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting3.Text == "O" && btnTesting6.Text == "O" && btnTesting9.Text == "O")
            {
                try
                {
                    btnTesting3.BackColor = Color.LightGray;
                    btnTesting6.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting1.Text == "O" && btnTesting2.Text == "O" && btnTesting3.Text == "O")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;
                    btnTesting2.BackColor = Color.LightGray;
                    btnTesting3.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting4.Text == "O" && btnTesting5.Text == "O" && btnTesting6.Text == "O")
            {
                try
                {
                    btnTesting4.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting6.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting7.Text == "O" && btnTesting8.Text == "O" && btnTesting9.Text == "O")
            {
                try
                {
                    btnTesting7.BackColor = Color.LightGray;
                    btnTesting8.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting1.Text == "O" && btnTesting5.Text == "O" && btnTesting9.Text == "O")
            {
                try
                {
                    btnTesting1.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting9.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnTesting7.Text == "O" && btnTesting5.Text == "O" && btnTesting3.Text == "O")
            {
                try
                {
                    btnTesting7.BackColor = Color.LightGray;
                    btnTesting5.BackColor = Color.LightGray;
                    btnTesting3.BackColor = Color.LightGray;
                    nextmessageBoxResultO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //If player X & player O are draw
            else if (btnTesting1.Text != btnTesting.Text && btnTesting2.Text != btnTesting.Text && btnTesting3.Text != btnTesting.Text &&
                btnTesting4.Text != btnTesting.Text && btnTesting5.Text != btnTesting.Text && btnTesting6.Text != btnTesting.Text &&
                btnTesting7.Text != btnTesting.Text && btnTesting8.Text != btnTesting.Text && btnTesting9.Text != btnTesting.Text)
            {
                try
                {
                    nextmessageBoxResultXO();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            continueNextRound();
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            try
            {
                continueNextRound();
                lblPXScore.Text = "0";
                lblPOScore.Text = "0";         
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}