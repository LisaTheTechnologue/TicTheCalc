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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void game_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            CalculatorStd calc = new CalculatorStd();
            calc.Show();
            this.Hide();
        }
    }
}
