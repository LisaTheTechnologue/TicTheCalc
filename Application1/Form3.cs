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
    public partial class CalculatorScf : Form
    {
        public CalculatorScf()
        {
            InitializeComponent();
        }

        string factor1 = "";
        string factor2 = "";
        string result;
        char operation;
        
        public void CalculatorStd()
        {
            InitializeComponent();
        }

        private void TxtBoxCalc_TextChanged(object sender, EventArgs e)
        {


        }


        private void SimpleCal_Load(object sender, EventArgs e)
        {


        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if (TxtBoxCalc.Text.Contains('.'))
            {
                MessageBox.Show("Sorry. Wrong format");
            }
            else TxtBoxCalc.Text += '.';
        }
        private void buttonMiPl_Click(object sender, EventArgs e)
        {
            if (TxtBoxCalc.Text == "")
            {
                TxtBoxCalc.Text = "-";
            }
            else if (Convert.ToDouble(TxtBoxCalc.Text) > 0)
            {
                TxtBoxCalc.Text = "-" + TxtBoxCalc.Text;
            }
            else if (Convert.ToDouble(TxtBoxCalc.Text) < 0)
            {
                TxtBoxCalc.Text = TxtBoxCalc.Text.Substring(1);
            }
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            TxtBoxCalc.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(TxtBoxCalc.Text)));
        }

        private void BtnSqr_Click(object sender, EventArgs e)
        {
            TxtBoxCalc.Text = Convert.ToString(Convert.ToDouble(TxtBoxCalc.Text) * Convert.ToDouble(TxtBoxCalc.Text));
        }
        private void BtnOnePer_Click(object sender, EventArgs e)
        {
            TxtBoxCalc.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtBoxCalc.Text));
        }
        
        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            factor1 = TxtBoxCalc.Text;
            switch (b.Text)
            {
                case "/":
                    operation = '/';
                    TxtBoxCalc.Text = "";
                    break;
                case "*":
                    operation = '*';
                    TxtBoxCalc.Text = "";
                    break;
                case "-":
                    if (TxtBoxCalc.Text == "")
                    {
                        TxtBoxCalc.Text = "-";
                    }
                    else
                    {
                        
                        operation = '-';
                        TxtBoxCalc.Text = "";
                    }
                    break;
                case "+":
                    operation = '+';
                    TxtBoxCalc.Text = "";
                    break;
                
            }
            
            
        }

        

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string TxtShown = TxtBoxCalc.Text;
            char[] arrChar = TxtBoxCalc.Text.ToCharArray();
            TxtBoxCalc.Text = "";
            for (int count = 0; count < TxtShown.Length - 1; count++)
            {
                TxtBoxCalc.Text += arrChar[count];
            }

        }

        

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            factor2 = TxtBoxCalc.Text;
            
            double fcr1 = Convert.ToDouble(factor1);
            double fcr2 = Convert.ToDouble(factor2);

            switch (operation)
            {
                case '+':
                    result = (fcr1 + fcr2).ToString();
                    break;

                case '-':
                    result = (fcr1 - fcr2).ToString();
                    break;

                case '*':
                    result = (fcr1 * fcr2).ToString();
                    break;

                case '/':
                    if (fcr2 != 0)
                    {
                        result = (fcr1 / fcr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
                           }

            TxtBoxCalc.Text = result;
        }


        private void click_Shown(object sender, EventArgs e)
        {
            if (TxtBoxCalc.Text == "0.")
            {
                TxtBoxCalc.Text = "";
            }
            try
            {
                Button btnNum = (Button)sender;

                if (Convert.ToDouble(btnNum.Text) / 1 == Convert.ToDouble(btnNum.Text))
                {
                    string num = btnNum.Text;
                    TxtBoxCalc.Text += num;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                   ex.Message);
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtBoxCalc.Text = "0.";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program is written by Chung Bao Ngan Tran", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorStd calc = new CalculatorStd();
            calc.Show();
            this.Hide();
        }
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently in the Scientific mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBoxCalc.Text = "0.";
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}
