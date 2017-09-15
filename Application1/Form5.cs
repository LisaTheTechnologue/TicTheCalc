using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1
{
    public partial class Game : Form
    {
        bool turn = true; //if true=X, else it is O
        int turnCount = 0; //To keep track of number of butten-click
        public Game()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The author of this game is Chung Bao Ngan Chan", "Tac Tic Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void click_Button(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")    // if not empty..already has X or O
            {
                MessageBox.Show("Button already has value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (turn)
            {
                btn.Text = "X";
                btn.ForeColor = Color.Blue;
                btn.Font = new Font("Arial", 24, FontStyle.Bold);
            }
            else
            {
                btn.Text = "O";
                btn.ForeColor = Color.Red;
                btn.Font = new Font("Arial", 24, FontStyle.Bold);
            }
            turn = !turn;
            turnCount++;


            check_For_winner();
        }

        private void check_For_winner()
        {
            string winnerChar = "";
            bool winner = false;
            //To check each row
            if ((btnA1.Text == btnB1.Text) && (btnC1.Text == btnB1.Text) && (btnA1.Text != ""))
            {
                winner = true;
                winnerChar = btnA1.Text;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnC2.Text == btnB2.Text) && (btnA2.Text != ""))
            {
                winner = true;
                winnerChar = btnA2.Text;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnC3.Text == btnB3.Text) && (btnA3.Text != ""))
            {
                winner = true;
                winnerChar = btnA3.Text;
            }

            //To check each column
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (btnA1.Text != ""))
            {
                winner = true;
                winnerChar = btnA1.Text;
            }
            if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (btnB1.Text != ""))
            {
                winner = true;
                winnerChar = btnB2.Text;
            }
            if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (btnC1.Text != ""))
            {
                winner = true;
                winnerChar = btnC1.Text;
            }

            //To check diag
            if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (btnA1.Text != ""))
            {
                winner = true;
                winnerChar = btnA1.Text;
            }
            if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (btnC1.Text != ""))
            {
                winner = true;
                winnerChar = btnA3.Text;
            }
            if (winner == true)
            {
                MessageBox.Show(winnerChar + " won the game", "Hurray", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableButtons();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw! Congrats to both!", "^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void disableButtons()
        {
            try
            {
                //foreach (Control c in Controls)
                //{
                //    Button b = (Button)c;
                //    b.Enabled = false;
                btnA1.Enabled = false;
                btnA2.Enabled = false;
                btnA3.Enabled = false;
                btnB1.Enabled = false;
                btnB2.Enabled = false;
                btnB3.Enabled = false;
                btnC1.Enabled = false;
                btnC2.Enabled = false;
                btnC3.Enabled = false;
            }
            catch { }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorStd calc = new CalculatorStd();
            calc.Show();
            this.Hide();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";
            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";
            turnCount = 0;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

