using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startgameButton_Click(object sender, EventArgs e)
        {
            int min_width = Convert.ToInt32(minwidthBox.Text);
            int max_width = Convert.ToInt32(minwidthBox.Text);
            int min_length = Convert.ToInt32(minlengthBox.Text);
            int max_length = Convert.ToInt32(maxlengthBox.Text);
            int enemies = Convert.ToInt32(enemiesBox.Text);

            GamePlay gp = new GamePlay(min_width, max_width, min_length, max_length, enemies);
            gp.setCaller(this);
            gp.Show();
            this.Hide();
        }
    }
}
