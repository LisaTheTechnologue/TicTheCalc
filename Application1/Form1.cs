using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Application1
{
    public partial class LogIn : Form
    {

        int countClicked = 3;
        
        public LogIn()
        {
            InitializeComponent();
        }
        private void PasswordLb_Click(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            countClicked--;
            Check();

        }
        protected void Check()
        {
            //extra work
            TextReader reader = new StreamReader("Password.txt");
            string UserCheck = reader.ReadLine();
            string PassCheck = reader.ReadLine();

            if (PasswordTxt.Text == PassCheck && UsernameTxt.Text == UserCheck)
            {
                Pic.ImageLocation = "../../img/Yes.png";
                Pic.SizeMode = PictureBoxSizeMode.AutoSize;
                //ResultText.Size = new Size(125, 40);
                ResultText.Text = "The Username and Password are correct";
                ResultText.ForeColor = System.Drawing.Color.Green;


                Choose app = new Choose();
                app.Show();
                this.Hide();
            }
            else if (countClicked != 0)
            {
                Pic.ImageLocation = "../../img/No.png";
                Pic.SizeMode = PictureBoxSizeMode.AutoSize;
                ResultText.Text = "Sorry. You have " + countClicked + " left";
                ResultText.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Pic.ImageLocation = "../../img/No.png";
                Pic.SizeMode = PictureBoxSizeMode.AutoSize;
                ResultText.Text = "Your account is locked!";
                ResultText.ForeColor = System.Drawing.Color.Red;
                LoginBtn.Visible = false;
                CancelBtn.Visible = false;
            }
            reader.Close();
        }
        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if ((PasswordTxt.Text != "" || UsernameTxt.Text != "") && (PasswordTxt.Text != "" && UsernameTxt.Text != ""))
            {
                LoginBtn.Enabled = true;
            }
            else
            {
                LoginBtn.Enabled = false;
            }
        }

        public void Form_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if ((PasswordTxt.Text != "" || UsernameTxt.Text != "") && (PasswordTxt.Text != "" && UsernameTxt.Text != ""))
            {
                LoginBtn.Enabled = true;
            }
            else
            {
                LoginBtn.Enabled = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

